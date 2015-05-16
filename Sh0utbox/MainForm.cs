using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Sh0utbox
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string MemberName;
        public string isModerator;
        public string session_id;
        public string secure_hash;
        public CookieContainer GlobalCookieContainer = new CookieContainer();

        private string downloadedFont;
        private string downloadedCSS;

        private List<Shout> shoutsList = new List<Shout>();
        private bool firstTimegetShouts = true;
        private int curShoutID = -1;

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (isModerator == "0")
                this.Text = "Sh0utBox - Logged in as " + MemberName;
            else
            {
                this.Text = "Sh0utBox - Logged in as " + MemberName + "[MOD]";
            }

            this.Activate();

            using (WebClient webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                downloadedFont = webClient.DownloadString("http://fonts.googleapis.com/css?family=Lato:100,300,400,100italic,300italic,400italic");
                downloadedCSS = webClient.DownloadString("http://pastebin.com/raw.php?i=5UFGf6QX");
            }
        }

        private void getShouts()
        {
            string HTMLsource = "";
            bool isSh0ut = false;

            HttpWebRequest request = (HttpWebRequest)
                        WebRequest.Create(
                            "http://www.nulled.io/index.php?s=" + session_id +
                            "&&app=shoutbox&module=ajax&section=coreAjax&secure_key=" + secure_hash +
                            "&type=getShouts&lastid=" + curShoutID + "global=1");

            if (curShoutID == -1)
            {
                isSh0ut = true;
                request =
                    (HttpWebRequest)
                        WebRequest.Create(
                            "http://www.nulled.io/index.php?s=" + session_id +
                            "&&app=shoutbox&module=ajax&section=coreAjax&secure_key=" + secure_hash +
                            "&type=getShouts&global=1");
            }

            request.CookieContainer = GlobalCookieContainer;
            request.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)";
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";

            using (Stream responseStream = request.GetResponse().GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string response = reader.ReadToEnd();

                if (!string.IsNullOrWhiteSpace(response))
                {
                    curShoutID = int.Parse(new Regex("id='shout-row-(.*)'>").Match(response).Groups[1].Value);


                    MatchCollection ShoutIDMatches = new Regex("id='shout-row-(.*)'>").Matches(response);

                    MatchCollection TagNameMatches =
                        new Regex(
                            "<a href=\"#\" class=\"at_member\" data-store=\"(.*)\" title=\"Insert member's name into Shout\">@</a>&nbsp;")
                            .Matches(response);

                    MatchCollection NameMatches =
                        new Regex(
                            "<a hovercard-ref=\"member\" hovercard-id=\".*\" data-ipb=\"noparse\" class=\"_hovertrigger url fn name  \" href='.*' title='View Profile'><span itemprop=\"name\">(.*)</span>")
                            .Matches(response);

                    MatchCollection MessageMatches =
                        new Regex("<span class='shoutbox_text'>(.*)</span>").Matches(response);

                    MatchCollection TimeMatches =
                        new Regex("<span class='right desc' title=''>(.*)</span>").Matches(response);

                    MatchCollection IDMatches =
                        new Regex(
                            "<a hovercard-ref=\"member\" hovercard-id=\"(.*)\" data-ipb=\"noparse\" class=\"_hovertrigger url fn name  \" href='.*' title='View Profile'><span itemprop=\"name\">.*</span>")
                            .Matches(response);

                    shoutsList.Clear();
                    if (MessageMatches.Count != 0)
                    {
                        for (int i = 0; i < MessageMatches.Count; i++)
                        {
                            shoutsList.Add(
                                new Shout(
                                    ShoutIDMatches[i].Groups[1].Value, TagNameMatches[i].Groups[1].Value,
                                    NameMatches[i].Groups[1].Value, MessageMatches[i].Groups[1].Value,
                                    TimeMatches[i].Groups[1].Value, IDMatches[i].Groups[1].Value));
                        }

                        foreach (Shout shout in shoutsList)
                        {
                            HTMLsource = HTMLsource + "<tr class='row2' id='shout-row-" + shout.shoutid + "'>";
                            HTMLsource = HTMLsource + "<td style='width: 1%; white-space: nowrap;'>";
                            HTMLsource = HTMLsource + "<a href=\"@[member=" + shout.tagname +
                                         "]\" class=\"at_member\" data-store=\"0\" title=\"Insert member's name into Shout\">@</a>&nbsp;";
                            HTMLsource = HTMLsource +
                                         "<a hovercard-ref=\"member\" data-ipb=\"noparse\" class=\"_hovertrigger url fn name  \" title='View Profile'><span itemprop=\"name\">" +
                                         shout.name + "</span></a>";
                            HTMLsource = HTMLsource + "</td>";
                            HTMLsource = HTMLsource + "<td style='width: 1%; white-space: nowrap;'>:</td>";
                            HTMLsource = HTMLsource + "<td style='width: 98%;'>";
                            HTMLsource = HTMLsource + "<span class='right desc' title=''>" + shout.time + "</span>";
                            HTMLsource = HTMLsource + "<span class='shoutbox_text'>" +
                                         TextUtils.CheckforEmoticons(
                                             TextUtils.MakeLink(
                                                 Regex.Replace(
                                                     shout.message, "href='.*' title='Member profile'>",
                                                     " title='Member profile'>"))) + "</span>";
                            HTMLsource = HTMLsource + "</td>";
                            HTMLsource = HTMLsource + "</tr>";
                        }
                    }
                    else
                    {
                        HTMLsource = response;
                    }

                    Invoke(
                        (MethodInvoker) delegate()
                        {
                            if (webBrowserForSB.Document.GetElementsByTagName("tbody") != null &&
                                webBrowserForSB.Document.GetElementsByTagName("tbody")[0] != null)
                            {
                                if(isSh0ut)
                                    webBrowserForSB.Document.GetElementsByTagName("tbody")[0].InnerHtml = HTMLsource;
                                else
                                {
                                    webBrowserForSB.Document.GetElementsByTagName("tbody")[0].InnerHtml = HTMLsource + webBrowserForSB.Document.GetElementsByTagName("tbody")[0].InnerHtml;
                                }
                            }
                        });
                }
            }
        }

        private void refreshShoutBoxTimer_Tick(object sender, EventArgs e)
        {
            
            Thread getShoutsThread = new Thread(getShouts) { IsBackground = true };

            getShoutsThread.Start();
        }

        private void SendSBMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            Invoke(
                (MethodInvoker) delegate()
                {
                    txtbMessage.Text = "";
                    txtbMessage.Focus();
                });

            HttpWebRequest request =
                (HttpWebRequest)
                    WebRequest.Create(
                        "http://www.nulled.io/index.php?s=" + session_id +
                        "&&app=shoutbox&module=ajax&section=coreAjax&secure_key=" + secure_hash + "&type=submit&lastid=" +
                        curShoutID + "&global=1");

            request.CookieContainer = GlobalCookieContainer;
            request.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)";

            request.Headers["X-Requested-With"] = "XMLHttpRequest";

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream requestStream = request.GetRequestStream())
            using (StreamWriter writer = new StreamWriter(requestStream))
            {
                writer.Write("shout=" + txtbMessagePrefix.Text.Trim() + message + txtbMessageSuffix.Text.Trim());
            }

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string HTMLsource = "";
                string source = reader.ReadToEnd();

                if (!string.IsNullOrWhiteSpace(source))
                {
                    if (source.Contains("error-Shout flooding is enabled."))
                    {
                        int timeLeft =
                            int.Parse(
                                new Regex("Please wait (.*) seconds before shouting again.").Match(source).Groups[1]
                                    .Value);
                        Thread.Sleep(timeLeft * 1000);
                        SendSBMessage(message);
                    }
                    else
                    {
                        curShoutID = int.Parse(new Regex("id='shout-row-(.*)'>").Match(source).Groups[1].Value);

                        MatchCollection ShoutIDMatches = new Regex("id='shout-row-(.*)'>").Matches(source);

                        MatchCollection TagNameMatches =
                            new Regex(
                                "<a href=\"#\" class=\"at_member\" data-store=\"(.*)\" title=\"Insert member's name into Shout\">@</a>&nbsp;")
                                .Matches(source);

                        MatchCollection NameMatches =
                            new Regex(
                                "<a hovercard-ref=\"member\" hovercard-id=\".*\" data-ipb=\"noparse\" class=\"_hovertrigger url fn name  \" href='.*' title='View Profile'><span itemprop=\"name\">(.*)</span>")
                                .Matches(source);

                        MatchCollection MessageMatches =
                            new Regex("<span class='shoutbox_text'>(.*)</span>").Matches(source);

                        MatchCollection TimeMatches =
                            new Regex("<span class='right desc' title=''>(.*)</span>").Matches(source);

                        MatchCollection IDMatches =
                            new Regex(
                                "<a hovercard-ref=\"member\" hovercard-id=\"(.*)\" data-ipb=\"noparse\" class=\"_hovertrigger url fn name  \" href='.*' title='View Profile'><span itemprop=\"name\">.*</span>")
                                .Matches(source);

                        shoutsList.Clear();
                        if (MessageMatches.Count != 0)
                        {
                            for (int i = 0; i < MessageMatches.Count; i++)
                            {
                                shoutsList.Add(
                                    new Shout(
                                        ShoutIDMatches[i].Groups[1].Value, TagNameMatches[i].Groups[1].Value,
                                        NameMatches[i].Groups[1].Value, MessageMatches[i].Groups[1].Value,
                                        TimeMatches[i].Groups[1].Value, IDMatches[i].Groups[1].Value));
                            }

                            foreach (Shout shout in shoutsList)
                            {
                                HTMLsource = HTMLsource + "<tr class='row2' id='shout-row-" + shout.shoutid + "'>";
                                HTMLsource = HTMLsource + "<td style='width: 1%; white-space: nowrap;'>";
                                HTMLsource = HTMLsource + "<a href=\"@[member=" + shout.tagname +
                                             "]\" class=\"at_member\" data-store=\"0\" title=\"Insert member's name into Shout\">@</a>&nbsp;";
                                HTMLsource = HTMLsource +
                                             "<a hovercard-ref=\"member\" data-ipb=\"noparse\" class=\"_hovertrigger url fn name  \" title='View Profile'><span itemprop=\"name\">" +
                                             shout.name + "</span></a>";
                                HTMLsource = HTMLsource + "</td>";
                                HTMLsource = HTMLsource + "<td style='width: 1%; white-space: nowrap;'>:</td>";
                                HTMLsource = HTMLsource + "<td style='width: 98%;'>";
                                HTMLsource = HTMLsource + "<span class='right desc' title=''>" + shout.time + "</span>";
                                HTMLsource = HTMLsource + "<span class='shoutbox_text'>" +
                                             TextUtils.CheckforEmoticons(
                                                 TextUtils.MakeLink(
                                                     Regex.Replace(
                                                         shout.message, "href='.*' title='Member profile'>",
                                                         " title='Member profile'>"))) + "</span>";
                                HTMLsource = HTMLsource + "</td>";
                                HTMLsource = HTMLsource + "</tr>";
                            }
                        }
                        else
                        {
                            HTMLsource = source;
                        }

                        Invoke(
                            (MethodInvoker) delegate()
                            {
                                if (webBrowserForSB.Document.GetElementsByTagName("tbody") != null &&
                                    webBrowserForSB.Document.GetElementsByTagName("tbody")[0] != null)
                                {
                                    webBrowserForSB.Document.GetElementsByTagName("tbody")[0].InnerHtml = HTMLsource +
                                                                                                          webBrowserForSB
                                                                                                              .Document
                                                                                                              .GetElementsByTagName
                                                                                                              ("tbody")[
                                                                                                                  0]
                                                                                                              .InnerHtml;
                                }
                            });
                    }
                }
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            txtbMessage.Focus();

            Thread sendShoutThread = new Thread(() => SendSBMessage(txtbMessage.Text)) { IsBackground = true };
            sendShoutThread.Start();
        }

        //Old, not used anymore.
        private string GetLastShoutID()
        {   
            HttpWebRequest request =
                (HttpWebRequest)
                    WebRequest.Create("http://www.nulled.io/index.php?s=" + session_id + "&&app=shoutbox&module=ajax&section=coreAjax&secure_key=" + secure_hash + "&type=getShouts&global=1");

            request.CookieContainer = GlobalCookieContainer;
            request.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)";
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";

            using (Stream responseStream = request.GetResponse().GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                return new Regex("<tr class='row2' id='shout-row-(.*)'>").Match(reader.ReadToEnd()).Groups[1].Value;
            }
        }

        private void webBrowserForSB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                webBrowserForSB.Document.ExecCommand("COPY", false, null);
        }

        private void webBrowserForSB_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString() != "about:blank")
            {
                e.Cancel = true;

                if (e.Url.ToString().Substring(0, 15) == "about:@[member=")
                {
                    txtbMessage.AppendText(e.Url.ToString().Replace("about:", "") + " ");
                    txtbMessage.Focus();
                    return;
                }

                Process.Start(e.Url.ToString());
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            txtbMessage.Size = new Size(metroPanel1.Size.Width - btnSendMessage.Size.Width + 1, txtbMessage.Size.Height);
            metroPanel1.Update();

            webBrowserForSB.Size = new Size(webBrowserForSB.Size.Width, tabShoutBox.Size.Height - metroPanel1.Size.Height);

            pmsTile.Location = new Point(this.Size.Width - 139, pmsTile.Location.Y);
            ntfsTile.Location = new Point(this.Size.Width - 91, ntfsTile.Location.Y);

            Application.DoEvents();
        }

        private void txtbMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnSendMessage.PerformClick();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            webBrowserForSB.DocumentText =
                    "<head><meta charset=\"UTF-8\"/><meta http-equiv='X-UA-Compatible' content='IE=edge'/><style>" + downloadedFont + "</style><style>" +
                    downloadedCSS +
                    "</style></head><body><div class=\"ipsBox_container\"><table class=\"ipb_table shoutbox_table\"><tbody><tr class=\"row1\"><td valign=\"top\" class=\"altrow\" colspan=\"2\"><div id=\"shoutbox-shouts\" style=\"height: 400px; overflow: auto; left: 0px; top: 0px;\"><table id='shoutbox-shouts-table'><tbody></tbody></table></div></td></tr></tbody></table></div></body></html>";

            refreshShoutBoxTimer.Enabled = true;
            refreshNotificationsTimer.Enabled = true;
        }

        private void pmsTile_MouseLeave(object sender, EventArgs e)
        {
            pmsTile.TileImage = Properties.Resources.icon_inbox1;
        }

        private void pmsTile_MouseEnter(object sender, EventArgs e)
        {
            pmsTile.TileImage = Properties.Resources.icon_inbox2;
        }

        private void ntfsTile_MouseLeave(object sender, EventArgs e)
        {
            ntfsTile.TileImage = Properties.Resources.icon_notify1;
        }

        private void ntfsTile_MouseEnter(object sender, EventArgs e)
        {
            ntfsTile.TileImage = Properties.Resources.icon_notify2;
        }

        private void refreshNotificationsTimer_Tick(object sender, EventArgs e)
        {
            Thread getNotificationsThread = new Thread(getNotifications) { IsBackground = true };
            getNotificationsThread.Start();
        }

        private void getNotifications()
        {
            HttpWebRequest request =
                (HttpWebRequest)
                    WebRequest.Create(
                        "http://www.nulled.io/index.php?s=" + session_id +
                        "&&app=core&module=ajax&section=getNotificationsCnt");

            request.CookieContainer = GlobalCookieContainer;
            request.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)";

            request.Headers["X-Requested-With"] = "XMLHttpRequest";

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream requestStream = request.GetRequestStream())
            using (StreamWriter writer = new StreamWriter(requestStream))
            {
                writer.Write("secure_key=" + secure_hash);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string source = reader.ReadToEnd();

                if (source != "{\"ntfs_cnt\":\"0\",\"pms_cnt\":\"0\"}")
                {
                    Notifications results = new JavaScriptSerializer().Deserialize<Notifications>(source);
                    pmsTile.Text = "    " + results.pms_cnt;
                    ntfsTile.Text = "    " + results.ntfs_cnt;
                }
            }
        }

        private void pmsTile_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.nulled.io/index.php?app=members&module=messaging");
        }

        private void ntfsTile_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.nulled.io/index.php?app=core&module=usercp&tab=core&area=notificationlog");
        }

    }
}
