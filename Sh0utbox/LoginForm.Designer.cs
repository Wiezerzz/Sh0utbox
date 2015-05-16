namespace Sh0utbox
{
    partial class LoginForm
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
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.chkbRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.txtbPassword = new Sh0utbox.MetroTextBoxEx();
            this.txtbUsername = new Sh0utbox.MetroTextBoxEx();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(56, 165);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkbRememberMe
            // 
            this.chkbRememberMe.AutoSize = true;
            this.chkbRememberMe.Location = new System.Drawing.Point(48, 142);
            this.chkbRememberMe.Name = "chkbRememberMe";
            this.chkbRememberMe.Size = new System.Drawing.Size(101, 15);
            this.chkbRememberMe.TabIndex = 2;
            this.chkbRememberMe.Text = "Remember me";
            this.chkbRememberMe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkbRememberMe.UseSelectable = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(8, 192);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(21, 23);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.Visible = false;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(48, 226);
            this.metroProgressBar1.MarqueeAnimationSpeed = 0;
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(134, 19);
            this.metroProgressBar1.TabIndex = 5;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar1.Visible = false;
            // 
            // txtbPassword
            // 
            this.txtbPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbPassword.Lines = new string[0];
            this.txtbPassword.Location = new System.Drawing.Point(48, 105);
            this.txtbPassword.MaxLength = 32767;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '●';
            this.txtbPassword.PromptText = "Password";
            this.txtbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbPassword.SelectedText = "";
            this.txtbPassword.Size = new System.Drawing.Size(134, 30);
            this.txtbPassword.TabIndex = 1;
            this.txtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbPassword.UseSelectable = true;
            this.txtbPassword.UseStyleColors = true;
            this.txtbPassword.UseSystemPasswordChar = true;
            this.txtbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPassword_KeyPress);
            // 
            // txtbUsername
            // 
            this.txtbUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtbUsername.Lines = new string[0];
            this.txtbUsername.Location = new System.Drawing.Point(48, 68);
            this.txtbUsername.MaxLength = 32767;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.PasswordChar = '\0';
            this.txtbUsername.PromptText = "Username";
            this.txtbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbUsername.SelectedText = "";
            this.txtbUsername.Size = new System.Drawing.Size(134, 30);
            this.txtbUsername.TabIndex = 0;
            this.txtbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtbUsername.UseSelectable = true;
            this.txtbUsername.UseStyleColors = true;
            this.txtbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbUsername_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 259);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.chkbRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Text = "Sh0utBox - Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroCheckBox chkbRememberMe;
        private MetroTextBoxEx txtbUsername;
        private MetroTextBoxEx txtbPassword;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}

