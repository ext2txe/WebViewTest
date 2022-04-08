namespace WebViewTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wv = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDiscord = new System.Windows.Forms.TabPage();
            this.lblButtonInnerText = new System.Windows.Forms.Label();
            this.textButtonInnerText = new System.Windows.Forms.TextBox();
            this.BtnGetButton = new System.Windows.Forms.Button();
            this.BtnOpenImageFolder = new System.Windows.Forms.Button();
            this.BtnSelectImageSaveFolder = new System.Windows.Forms.Button();
            this.textImageSaveFolder = new System.Windows.Forms.TextBox();
            this.btnTakeScreenshot = new System.Windows.Forms.Button();
            this.textDocumentTitle = new System.Windows.Forms.TextBox();
            this.BtnGetTitle = new System.Windows.Forms.Button();
            this.textStartUrl = new System.Windows.Forms.TextBox();
            this.BtnSetDiscordUrl = new System.Windows.Forms.Button();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.textLog = new System.Windows.Forms.TextBox();
            this.tabUpwork = new System.Windows.Forms.TabPage();
            this.textUpworkUrl = new System.Windows.Forms.TextBox();
            this.BtnNavigateToUpwork = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.chkAllowHttpOverride = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDiscord.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabUpwork.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1464, 750);
            this.splitContainer1.SplitterDistance = 810;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.textUrl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 44);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(729, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 39);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(56, 3);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(670, 39);
            this.textUrl.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 699);
            this.panel2.TabIndex = 5;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(804, 699);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wv);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wv
            // 
            this.wv.CreationProperties = null;
            this.wv.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wv.Location = new System.Drawing.Point(3, 3);
            this.wv.Name = "wv";
            this.wv.Size = new System.Drawing.Size(790, 648);
            this.wv.Source = new System.Uri("https://discord.gg", System.UriKind.Absolute);
            this.wv.TabIndex = 0;
            this.wv.ZoomFactor = 1D;
            this.wv.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.wv_CoreWebView2InitializationCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUpwork);
            this.tabControl1.Controls.Add(this.tabDiscord);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 750);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDiscord
            // 
            this.tabDiscord.Controls.Add(this.lblButtonInnerText);
            this.tabDiscord.Controls.Add(this.textButtonInnerText);
            this.tabDiscord.Controls.Add(this.BtnGetButton);
            this.tabDiscord.Controls.Add(this.BtnOpenImageFolder);
            this.tabDiscord.Controls.Add(this.BtnSelectImageSaveFolder);
            this.tabDiscord.Controls.Add(this.textImageSaveFolder);
            this.tabDiscord.Controls.Add(this.btnTakeScreenshot);
            this.tabDiscord.Controls.Add(this.textDocumentTitle);
            this.tabDiscord.Controls.Add(this.BtnGetTitle);
            this.tabDiscord.Controls.Add(this.textStartUrl);
            this.tabDiscord.Controls.Add(this.BtnSetDiscordUrl);
            this.tabDiscord.Location = new System.Drawing.Point(4, 41);
            this.tabDiscord.Name = "tabDiscord";
            this.tabDiscord.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscord.Size = new System.Drawing.Size(641, 705);
            this.tabDiscord.TabIndex = 0;
            this.tabDiscord.Text = "Discord";
            this.tabDiscord.UseVisualStyleBackColor = true;
            // 
            // lblButtonInnerText
            // 
            this.lblButtonInnerText.AutoSize = true;
            this.lblButtonInnerText.Location = new System.Drawing.Point(6, 190);
            this.lblButtonInnerText.Name = "lblButtonInnerText";
            this.lblButtonInnerText.Size = new System.Drawing.Size(198, 32);
            this.lblButtonInnerText.TabIndex = 10;
            this.lblButtonInnerText.Text = "Button Inner Text";
            // 
            // textButtonInnerText
            // 
            this.textButtonInnerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textButtonInnerText.Location = new System.Drawing.Point(212, 187);
            this.textButtonInnerText.Name = "textButtonInnerText";
            this.textButtonInnerText.Size = new System.Drawing.Size(330, 39);
            this.textButtonInnerText.TabIndex = 9;
            this.textButtonInnerText.Text = "Open Discord in your browser";
            // 
            // BtnGetButton
            // 
            this.BtnGetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGetButton.Location = new System.Drawing.Point(548, 185);
            this.BtnGetButton.Name = "BtnGetButton";
            this.BtnGetButton.Size = new System.Drawing.Size(85, 40);
            this.BtnGetButton.TabIndex = 8;
            this.BtnGetButton.Text = "Test";
            this.BtnGetButton.UseVisualStyleBackColor = true;
            this.BtnGetButton.Click += new System.EventHandler(this.BtnGetButton_Click);
            // 
            // BtnOpenImageFolder
            // 
            this.BtnOpenImageFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenImageFolder.Location = new System.Drawing.Point(548, 114);
            this.BtnOpenImageFolder.Name = "BtnOpenImageFolder";
            this.BtnOpenImageFolder.Size = new System.Drawing.Size(85, 40);
            this.BtnOpenImageFolder.TabIndex = 7;
            this.BtnOpenImageFolder.Text = "Open";
            this.toolTip1.SetToolTip(this.BtnOpenImageFolder, "open screenshot folder with explorer");
            this.BtnOpenImageFolder.UseVisualStyleBackColor = true;
            this.BtnOpenImageFolder.Click += new System.EventHandler(this.BtnOpenImageFolder_Click);
            // 
            // BtnSelectImageSaveFolder
            // 
            this.BtnSelectImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectImageSaveFolder.Location = new System.Drawing.Point(504, 114);
            this.BtnSelectImageSaveFolder.Name = "BtnSelectImageSaveFolder";
            this.BtnSelectImageSaveFolder.Size = new System.Drawing.Size(40, 40);
            this.BtnSelectImageSaveFolder.TabIndex = 6;
            this.BtnSelectImageSaveFolder.Text = "..";
            this.toolTip1.SetToolTip(this.BtnSelectImageSaveFolder, "Select folder to use for screenshots");
            this.BtnSelectImageSaveFolder.UseVisualStyleBackColor = true;
            this.BtnSelectImageSaveFolder.Click += new System.EventHandler(this.BtnSelectImageSaveFolder_Click);
            // 
            // textImageSaveFolder
            // 
            this.textImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textImageSaveFolder.Location = new System.Drawing.Point(192, 115);
            this.textImageSaveFolder.Name = "textImageSaveFolder";
            this.textImageSaveFolder.Size = new System.Drawing.Size(306, 39);
            this.textImageSaveFolder.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textImageSaveFolder, "folder where screenshot will be saved");
            this.textImageSaveFolder.TextChanged += new System.EventHandler(this.textImageSaveFolder_TextChanged);
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.Location = new System.Drawing.Point(6, 114);
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(160, 40);
            this.btnTakeScreenshot.TabIndex = 4;
            this.btnTakeScreenshot.Text = "Screenshot";
            this.toolTip1.SetToolTip(this.btnTakeScreenshot, "Take screenshot of current browser page");
            this.btnTakeScreenshot.UseVisualStyleBackColor = true;
            this.btnTakeScreenshot.Click += new System.EventHandler(this.btnTakeScreenshot_Click);
            // 
            // textDocumentTitle
            // 
            this.textDocumentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDocumentTitle.Location = new System.Drawing.Point(124, 62);
            this.textDocumentTitle.Name = "textDocumentTitle";
            this.textDocumentTitle.Size = new System.Drawing.Size(509, 39);
            this.textDocumentTitle.TabIndex = 3;
            this.textDocumentTitle.Text = "https://discord.gg";
            // 
            // BtnGetTitle
            // 
            this.BtnGetTitle.Location = new System.Drawing.Point(45, 61);
            this.BtnGetTitle.Name = "BtnGetTitle";
            this.BtnGetTitle.Size = new System.Drawing.Size(85, 40);
            this.BtnGetTitle.TabIndex = 2;
            this.BtnGetTitle.Text = "Get Title";
            this.BtnGetTitle.UseVisualStyleBackColor = true;
            this.BtnGetTitle.Click += new System.EventHandler(this.BtnGetTitle_Click);
            // 
            // textStartUrl
            // 
            this.textStartUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textStartUrl.Location = new System.Drawing.Point(124, 11);
            this.textStartUrl.Name = "textStartUrl";
            this.textStartUrl.Size = new System.Drawing.Size(509, 39);
            this.textStartUrl.TabIndex = 1;
            this.textStartUrl.Text = "https://discord.gg";
            // 
            // BtnSetDiscordUrl
            // 
            this.BtnSetDiscordUrl.Location = new System.Drawing.Point(45, 10);
            this.BtnSetDiscordUrl.Name = "BtnSetDiscordUrl";
            this.BtnSetDiscordUrl.Size = new System.Drawing.Size(85, 40);
            this.BtnSetDiscordUrl.TabIndex = 0;
            this.BtnSetDiscordUrl.Text = "Set url";
            this.BtnSetDiscordUrl.UseVisualStyleBackColor = true;
            this.BtnSetDiscordUrl.Click += new System.EventHandler(this.BtnGoToDiscord_Click);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.textLog);
            this.tabLog.Location = new System.Drawing.Point(4, 41);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(641, 705);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // textLog
            // 
            this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLog.Location = new System.Drawing.Point(3, 3);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLog.Size = new System.Drawing.Size(635, 699);
            this.textLog.TabIndex = 0;
            // 
            // tabUpwork
            // 
            this.tabUpwork.Controls.Add(this.textUpworkUrl);
            this.tabUpwork.Controls.Add(this.BtnNavigateToUpwork);
            this.tabUpwork.Location = new System.Drawing.Point(4, 41);
            this.tabUpwork.Name = "tabUpwork";
            this.tabUpwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpwork.Size = new System.Drawing.Size(641, 705);
            this.tabUpwork.TabIndex = 2;
            this.tabUpwork.Text = "Upwork";
            this.tabUpwork.UseVisualStyleBackColor = true;
            // 
            // textUpworkUrl
            // 
            this.textUpworkUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUpworkUrl.Location = new System.Drawing.Point(16, 7);
            this.textUpworkUrl.Name = "textUpworkUrl";
            this.textUpworkUrl.Size = new System.Drawing.Size(509, 39);
            this.textUpworkUrl.TabIndex = 5;
            this.textUpworkUrl.Text = "https://www.upwork.com";
            // 
            // BtnNavigateToUpwork
            // 
            this.BtnNavigateToUpwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNavigateToUpwork.Location = new System.Drawing.Point(548, 7);
            this.BtnNavigateToUpwork.Name = "BtnNavigateToUpwork";
            this.BtnNavigateToUpwork.Size = new System.Drawing.Size(85, 40);
            this.BtnNavigateToUpwork.TabIndex = 4;
            this.BtnNavigateToUpwork.Text = "Go";
            this.BtnNavigateToUpwork.UseVisualStyleBackColor = true;
            this.BtnNavigateToUpwork.Click += new System.EventHandler(this.BtnNavigateToUpwork_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 752);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1464, 39);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 32);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.chkAllowHttpOverride);
            this.tabSettings.Location = new System.Drawing.Point(4, 41);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(641, 705);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // chkAllowHttpOverride
            // 
            this.chkAllowHttpOverride.AutoSize = true;
            this.chkAllowHttpOverride.Checked = true;
            this.chkAllowHttpOverride.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowHttpOverride.Location = new System.Drawing.Point(33, 41);
            this.chkAllowHttpOverride.Name = "chkAllowHttpOverride";
            this.chkAllowHttpOverride.Size = new System.Drawing.Size(260, 36);
            this.chkAllowHttpOverride.TabIndex = 0;
            this.chkAllowHttpOverride.Text = "Allow HTTP Override";
            this.toolTip1.SetToolTip(this.chkAllowHttpOverride, "Ask user whether to navigate to HTTP");
            this.chkAllowHttpOverride.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1464, 791);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "WebView Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDiscord.ResumeLayout(false);
            this.tabDiscord.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabUpwork.ResumeLayout(false);
            this.tabUpwork.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv;
        private Button btnGo;
        private TextBox textUrl;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabDiscord;
        private TabPage tabLog;
        private TextBox textLog;
        private Button BtnSetDiscordUrl;
        private TextBox textDocumentTitle;
        private Button BtnGetTitle;
        private TextBox textStartUrl;
        private Button btnTakeScreenshot;
        private Button BtnSelectImageSaveFolder;
        private TextBox textImageSaveFolder;
        private Button BtnOpenImageFolder;
        private ToolTip toolTip1;
        private Label lblButtonInnerText;
        private TextBox textButtonInnerText;
        private Button BtnGetButton;
        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabUpwork;
        private TextBox textUpworkUrl;
        private Button BtnNavigateToUpwork;
        private TabPage tabSettings;
        private CheckBox chkAllowHttpOverride;
    }
}