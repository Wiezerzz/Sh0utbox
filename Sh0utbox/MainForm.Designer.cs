namespace Sh0utbox
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.webBrowserForSB = new System.Windows.Forms.WebBrowser();
            this.btnSendMessage = new MetroFramework.Controls.MetroButton();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabShoutBox = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.lblMessageSuffix = new MetroFramework.Controls.MetroLabel();
            this.lblMessagePrefix = new MetroFramework.Controls.MetroLabel();
            this.tabAutoMessage = new MetroFramework.Controls.MetroTabPage();
            this.refreshShoutBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.pmsTile = new MetroFramework.Controls.MetroTile();
            this.ntfsTile = new MetroFramework.Controls.MetroTile();
            this.refreshNotificationsTimer = new System.Windows.Forms.Timer(this.components);
            this.txtbMessage = new Sh0utbox.MetroTextBoxEx();
            this.txtbMessageSuffix = new Sh0utbox.MetroTextBoxEx();
            this.txtbMessagePrefix = new Sh0utbox.MetroTextBoxEx();
            this.metroTabControl.SuspendLayout();
            this.tabShoutBox.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserForSB
            // 
            this.webBrowserForSB.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowserForSB.Location = new System.Drawing.Point(0, 0);
            this.webBrowserForSB.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserForSB.Name = "webBrowserForSB";
            this.webBrowserForSB.ScriptErrorsSuppressed = true;
            this.webBrowserForSB.ScrollBarsEnabled = false;
            this.webBrowserForSB.Size = new System.Drawing.Size(774, 320);
            this.webBrowserForSB.TabIndex = 0;
            this.webBrowserForSB.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webBrowserForSB.WebBrowserShortcutsEnabled = false;
            this.webBrowserForSB.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowserForSB_Navigating);
            this.webBrowserForSB.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowserForSB_PreviewKeyDown);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendMessage.Location = new System.Drawing.Point(678, 0);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(96, 30);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSendMessage.UseSelectable = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl.Controls.Add(this.tabShoutBox);
            this.metroTabControl.Controls.Add(this.tabAutoMessage);
            this.metroTabControl.Controls.Add(this.tabSettings);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(782, 392);
            this.metroTabControl.TabIndex = 2;
            this.metroTabControl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl.UseSelectable = true;
            // 
            // tabShoutBox
            // 
            this.tabShoutBox.Controls.Add(this.metroPanel1);
            this.tabShoutBox.Controls.Add(this.webBrowserForSB);
            this.tabShoutBox.HorizontalScrollbarBarColor = true;
            this.tabShoutBox.HorizontalScrollbarHighlightOnWheel = false;
            this.tabShoutBox.HorizontalScrollbarSize = 10;
            this.tabShoutBox.Location = new System.Drawing.Point(4, 41);
            this.tabShoutBox.Name = "tabShoutBox";
            this.tabShoutBox.Size = new System.Drawing.Size(774, 347);
            this.tabShoutBox.TabIndex = 0;
            this.tabShoutBox.Text = "ShoutBox";
            this.tabShoutBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabShoutBox.VerticalScrollbarBarColor = true;
            this.tabShoutBox.VerticalScrollbarHighlightOnWheel = false;
            this.tabShoutBox.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSendMessage);
            this.metroPanel1.Controls.Add(this.txtbMessage);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 317);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(774, 30);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblMessageSuffix);
            this.tabSettings.Controls.Add(this.lblMessagePrefix);
            this.tabSettings.Controls.Add(this.txtbMessageSuffix);
            this.tabSettings.Controls.Add(this.txtbMessagePrefix);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 41);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(774, 347);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // lblMessageSuffix
            // 
            this.lblMessageSuffix.AutoSize = true;
            this.lblMessageSuffix.Location = new System.Drawing.Point(253, 22);
            this.lblMessageSuffix.Name = "lblMessageSuffix";
            this.lblMessageSuffix.Size = new System.Drawing.Size(98, 19);
            this.lblMessageSuffix.TabIndex = 3;
            this.lblMessageSuffix.Text = "Message Suffix:";
            this.lblMessageSuffix.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblMessagePrefix
            // 
            this.lblMessagePrefix.AutoSize = true;
            this.lblMessagePrefix.Location = new System.Drawing.Point(3, 22);
            this.lblMessagePrefix.Name = "lblMessagePrefix";
            this.lblMessagePrefix.Size = new System.Drawing.Size(100, 19);
            this.lblMessagePrefix.TabIndex = 2;
            this.lblMessagePrefix.Text = "Message Prefix:";
            this.lblMessagePrefix.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tabAutoMessage
            // 
            this.tabAutoMessage.BackColor = System.Drawing.SystemColors.Control;
            this.tabAutoMessage.HorizontalScrollbarBarColor = true;
            this.tabAutoMessage.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAutoMessage.HorizontalScrollbarSize = 10;
            this.tabAutoMessage.Location = new System.Drawing.Point(4, 41);
            this.tabAutoMessage.Name = "tabAutoMessage";
            this.tabAutoMessage.Size = new System.Drawing.Size(774, 347);
            this.tabAutoMessage.TabIndex = 1;
            this.tabAutoMessage.Text = "AutoMessage";
            this.tabAutoMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabAutoMessage.VerticalScrollbarBarColor = true;
            this.tabAutoMessage.VerticalScrollbarHighlightOnWheel = false;
            this.tabAutoMessage.VerticalScrollbarSize = 10;
            // 
            // refreshShoutBoxTimer
            // 
            this.refreshShoutBoxTimer.Interval = 2500;
            this.refreshShoutBoxTimer.Tick += new System.EventHandler(this.refreshShoutBoxTimer_Tick);
            // 
            // pmsTile
            // 
            this.pmsTile.ActiveControl = null;
            this.pmsTile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pmsTile.Location = new System.Drawing.Point(683, 35);
            this.pmsTile.Name = "pmsTile";
            this.pmsTile.Size = new System.Drawing.Size(48, 19);
            this.pmsTile.TabIndex = 5;
            this.pmsTile.Text = "    0";
            this.pmsTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pmsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("pmsTile.TileImage")));
            this.pmsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.pmsTile.UseCustomBackColor = true;
            this.pmsTile.UseSelectable = true;
            this.pmsTile.UseStyleColors = true;
            this.pmsTile.UseTileImage = true;
            this.pmsTile.Click += new System.EventHandler(this.pmsTile_Click);
            this.pmsTile.MouseEnter += new System.EventHandler(this.pmsTile_MouseEnter);
            this.pmsTile.MouseLeave += new System.EventHandler(this.pmsTile_MouseLeave);
            // 
            // ntfsTile
            // 
            this.ntfsTile.ActiveControl = null;
            this.ntfsTile.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ntfsTile.Location = new System.Drawing.Point(731, 35);
            this.ntfsTile.Name = "ntfsTile";
            this.ntfsTile.Size = new System.Drawing.Size(48, 19);
            this.ntfsTile.TabIndex = 4;
            this.ntfsTile.Text = "    0";
            this.ntfsTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ntfsTile.TileImage = ((System.Drawing.Image)(resources.GetObject("ntfsTile.TileImage")));
            this.ntfsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.ntfsTile.UseCustomBackColor = true;
            this.ntfsTile.UseSelectable = true;
            this.ntfsTile.UseStyleColors = true;
            this.ntfsTile.UseTileImage = true;
            this.ntfsTile.Click += new System.EventHandler(this.ntfsTile_Click);
            this.ntfsTile.MouseEnter += new System.EventHandler(this.ntfsTile_MouseEnter);
            this.ntfsTile.MouseLeave += new System.EventHandler(this.ntfsTile_MouseLeave);
            // 
            // refreshNotificationsTimer
            // 
            this.refreshNotificationsTimer.Interval = 5000;
            this.refreshNotificationsTimer.Tick += new System.EventHandler(this.refreshNotificationsTimer_Tick);
            // 
            // txtbMessage
            // 
            this.txtbMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtbMessage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbMessage.Lines = new string[0];
            this.txtbMessage.Location = new System.Drawing.Point(0, 0);
            this.txtbMessage.MaxLength = 32767;
            this.txtbMessage.Name = "txtbMessage";
            this.txtbMessage.PasswordChar = '\0';
            this.txtbMessage.PromptText = "Message...";
            this.txtbMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbMessage.SelectedText = "";
            this.txtbMessage.Size = new System.Drawing.Size(680, 30);
            this.txtbMessage.TabIndex = 0;
            this.txtbMessage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbMessage.UseSelectable = true;
            this.txtbMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbMessage_KeyPress);
            // 
            // txtbMessageSuffix
            // 
            this.txtbMessageSuffix.Lines = new string[0];
            this.txtbMessageSuffix.Location = new System.Drawing.Point(357, 22);
            this.txtbMessageSuffix.MaxLength = 32767;
            this.txtbMessageSuffix.Name = "txtbMessageSuffix";
            this.txtbMessageSuffix.PasswordChar = '\0';
            this.txtbMessageSuffix.PromptText = "[/color]";
            this.txtbMessageSuffix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbMessageSuffix.SelectedText = "";
            this.txtbMessageSuffix.Size = new System.Drawing.Size(138, 24);
            this.txtbMessageSuffix.TabIndex = 5;
            this.txtbMessageSuffix.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbMessageSuffix.UseSelectable = true;
            // 
            // txtbMessagePrefix
            // 
            this.txtbMessagePrefix.Lines = new string[0];
            this.txtbMessagePrefix.Location = new System.Drawing.Point(109, 22);
            this.txtbMessagePrefix.MaxLength = 32767;
            this.txtbMessagePrefix.Name = "txtbMessagePrefix";
            this.txtbMessagePrefix.PasswordChar = '\0';
            this.txtbMessagePrefix.PromptText = "[color=blue]";
            this.txtbMessagePrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbMessagePrefix.SelectedText = "";
            this.txtbMessagePrefix.Size = new System.Drawing.Size(138, 24);
            this.txtbMessagePrefix.TabIndex = 4;
            this.txtbMessagePrefix.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbMessagePrefix.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.ntfsTile);
            this.Controls.Add(this.pmsTile);
            this.Controls.Add(this.metroTabControl);
            this.Name = "MainForm";
            this.Text = "Sh0utBox - Logged in as";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.metroTabControl.ResumeLayout(false);
            this.tabShoutBox.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserForSB;
        private MetroFramework.Controls.MetroButton btnSendMessage;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage tabShoutBox;
        private MetroFramework.Controls.MetroTabPage tabAutoMessage;
        private MetroTextBoxEx txtbMessage;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Timer refreshShoutBoxTimer;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroTextBoxEx txtbMessageSuffix;
        private MetroTextBoxEx txtbMessagePrefix;
        private MetroFramework.Controls.MetroLabel lblMessageSuffix;
        private MetroFramework.Controls.MetroLabel lblMessagePrefix;
        private MetroFramework.Controls.MetroTile ntfsTile;
        private MetroFramework.Controls.MetroTile pmsTile;
        private System.Windows.Forms.Timer refreshNotificationsTimer;
    }
}