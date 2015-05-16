using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Sh0utbox
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Native
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);
        const int INTERNET_COOKIE_HTTPONLY = 0x00002000;

        public static string GetGlobalCookies(string uri)
        {
            uint datasize = 1024;
            StringBuilder cookieData = new StringBuilder((int)datasize);
            if (InternetGetCookieEx(uri, null, cookieData, ref datasize, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero)
                && cookieData.Length > 0)
            {
                return cookieData.ToString().Replace(';', ',');
            }
            else
            {
                return null;
            }
        }

        #endregion

        // A custom WebClient featuring a cookie container.
        public class WebClientEx : WebClient
        {
            public CookieContainer CookieContainer { get; set; }

            public WebClientEx()
            {
                CookieContainer = new CookieContainer();
            }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request is HttpWebRequest)
                {
                    (request as HttpWebRequest).CookieContainer = CookieContainer;
                }
                return request;
            }
        }


        private CookieContainer GlobalCookieContainer = new CookieContainer();
        private bool gotCFCookies;
        private int cnt = 0;

        #region Form Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void txtbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtbPassword.Focus();
            }
        }

        private void txtbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtbUsername.Enabled = false;
            txtbPassword.Enabled = false;
            chkbRememberMe.Enabled = false;
            btnLogin.Enabled = false;
            metroProgressBar1.Visible = true;

            if (!gotCFCookies)
                webBrowser.Navigate("http://www.nulled.io/");
            else
            {
                doLogin(txtbUsername.Text, txtbPassword.Text, getAuthKey());
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser.ReadyState != WebBrowserReadyState.Complete)
                return;

            cnt++;

            if (cnt == 2)
            {
                GlobalCookieContainer.SetCookies(
                    new Uri("http://www.nulled.io"), GetGlobalCookies(webBrowser.Document.Url.AbsoluteUri));
                gotCFCookies = true;

                webBrowser.Navigate("about:login");

                doLogin(txtbUsername.Text, txtbPassword.Text, getAuthKey());
            }
        }

        private void doLogin(string cUser, string cPass, string cAuthkey)
        {
            ServicePointManager.Expect100Continue = false;

            HttpWebRequest request =
                (HttpWebRequest)
                    WebRequest.Create("http://www.nulled.io/index.php?app=core&module=global&section=login&do=process");

            request.CookieContainer = GlobalCookieContainer;
            request.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)";

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (Stream requestStream = request.GetRequestStream())
            using (StreamWriter writer = new StreamWriter(requestStream))
            {
                writer.Write(
                    "auth_key=" + cAuthkey + "&ips_username=" + cUser + "&ips_password=" + cPass + "&rememberMe=1");
            }

            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            GlobalCookieContainer.Add(response.Cookies);
            using (var responseStream = response.GetResponseStream())
            using (var reader = new StreamReader(responseStream))
            {
                string result = reader.ReadToEnd();

                if (result.Contains("Username or password incorrect."))
                {
                    MetroMessageBox.Show(
                        this, "Username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.MemberName = new Regex("member_name.*= '(.*)';").Match(result).Groups[1].Value;
                    mainForm.session_id = new Regex("'session_id'].*= '(.*)';").Match(result).Groups[1].Value;
                    mainForm.secure_hash = new Regex("'secure_hash'].*= '(.*)';").Match(result).Groups[1].Value;
                    mainForm.isModerator = new Regex("ipb.shoutbox.moderator.*= (.*);").Match(result).Groups[1].Value;
                    mainForm.GlobalCookieContainer = GlobalCookieContainer;
                    mainForm.FormClosed += mainForm_FormClosed;
                    mainForm.Show();
                    this.Hide();
                }

                //
                txtbUsername.Enabled = true;
                txtbPassword.Enabled = true;
                chkbRememberMe.Enabled = true;
                btnLogin.Enabled = true;
                metroProgressBar1.Visible = false;
                //
            }
        }

        private string getAuthKey()
        {
            string key = "";

            HttpWebRequest request =
                (HttpWebRequest)
                    WebRequest.Create("http://www.nulled.io/index.php?app=core&module=global&section=login");

            request.CookieContainer = GlobalCookieContainer;
            request.UserAgent =
                "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; InfoPath.3)";
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";

            using (Stream responseStream = request.GetResponse().GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string result = reader.ReadToEnd();
                key = new Regex("name='auth_key' value='(.*)'").Match(result).Groups[1].Value;
            }

            return key;
        }
    }
}
