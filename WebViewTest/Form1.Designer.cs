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
            this.btnGo = new System.Windows.Forms.Button();
            this.wv = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDiscord.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1302, 594);
            this.splitContainer1.SplitterDistance = 721;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(640, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 39);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // wv
            // 
            this.wv.CreationProperties = null;
            this.wv.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wv.Location = new System.Drawing.Point(3, 3);
            this.wv.Name = "wv";
            this.wv.Size = new System.Drawing.Size(701, 492);
            this.wv.Source = new System.Uri("https://discord.gg", System.UriKind.Absolute);
            this.wv.TabIndex = 0;
            this.wv.ZoomFactor = 1D;
            this.wv.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.wv_CoreWebView2InitializationCompleted);
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(56, 3);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(581, 39);
            this.textUrl.TabIndex = 1;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDiscord);
            this.tabControl1.Controls.Add(this.tabLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 594);
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
            this.tabDiscord.Size = new System.Drawing.Size(568, 549);
            this.tabDiscord.TabIndex = 0;
            this.tabDiscord.Text = "Discord";
            this.tabDiscord.UseVisualStyleBackColor = true;
            // 
            // lblButtonInnerText
            // 
            this.lblButtonInnerText.AutoSize = true;
            this.lblButtonInnerText.Location = new System.Drawing.Point(13, 160);
            this.lblButtonInnerText.Name = "lblButtonInnerText";
            this.lblButtonInnerText.Size = new System.Drawing.Size(198, 32);
            this.lblButtonInnerText.TabIndex = 10;
            this.lblButtonInnerText.Text = "Button Inner Text";
            // 
            // textButtonInnerText
            // 
            this.textButtonInnerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textButtonInnerText.Location = new System.Drawing.Point(145, 155);
            this.textButtonInnerText.Name = "textButtonInnerText";
            this.textButtonInnerText.Size = new System.Drawing.Size(346, 39);
            this.textButtonInnerText.TabIndex = 9;
            this.textButtonInnerText.Text = "Open Discord in your browser";
            // 
            // BtnGetButton
            // 
            this.BtnGetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGetButton.Location = new System.Drawing.Point(509, 153);
            this.BtnGetButton.Name = "BtnGetButton";
            this.BtnGetButton.Size = new System.Drawing.Size(51, 31);
            this.BtnGetButton.TabIndex = 8;
            this.BtnGetButton.Text = "Test";
            this.BtnGetButton.UseVisualStyleBackColor = true;
            this.BtnGetButton.Click += new System.EventHandler(this.BtnGetButton_Click);
            // 
            // BtnOpenImageFolder
            // 
            this.BtnOpenImageFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenImageFolder.Location = new System.Drawing.Point(485, 82);
            this.BtnOpenImageFolder.Name = "BtnOpenImageFolder";
            this.BtnOpenImageFolder.Size = new System.Drawing.Size(75, 31);
            this.BtnOpenImageFolder.TabIndex = 7;
            this.BtnOpenImageFolder.Text = "Open";
            this.toolTip1.SetToolTip(this.BtnOpenImageFolder, "open screenshot folder with explorer");
            this.BtnOpenImageFolder.UseVisualStyleBackColor = true;
            this.BtnOpenImageFolder.Click += new System.EventHandler(this.BtnOpenImageFolder_Click);
            // 
            // BtnSelectImageSaveFolder
            // 
            this.BtnSelectImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectImageSaveFolder.Location = new System.Drawing.Point(451, 82);
            this.BtnSelectImageSaveFolder.Name = "BtnSelectImageSaveFolder";
            this.BtnSelectImageSaveFolder.Size = new System.Drawing.Size(29, 31);
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
            this.textImageSaveFolder.Location = new System.Drawing.Point(124, 81);
            this.textImageSaveFolder.Name = "textImageSaveFolder";
            this.textImageSaveFolder.Size = new System.Drawing.Size(321, 39);
            this.textImageSaveFolder.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textImageSaveFolder, "folder where screenshot will be saved");
            this.textImageSaveFolder.TextChanged += new System.EventHandler(this.textImageSaveFolder_TextChanged);
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.Location = new System.Drawing.Point(6, 82);
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(114, 31);
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
            this.textDocumentTitle.Location = new System.Drawing.Point(124, 46);
            this.textDocumentTitle.Name = "textDocumentTitle";
            this.textDocumentTitle.Size = new System.Drawing.Size(436, 39);
            this.textDocumentTitle.TabIndex = 3;
            this.textDocumentTitle.Text = "https://discord.gg";
            // 
            // BtnGetTitle
            // 
            this.BtnGetTitle.Location = new System.Drawing.Point(45, 45);
            this.BtnGetTitle.Name = "BtnGetTitle";
            this.BtnGetTitle.Size = new System.Drawing.Size(75, 31);
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
            this.textStartUrl.Size = new System.Drawing.Size(436, 39);
            this.textStartUrl.TabIndex = 1;
            this.textStartUrl.Text = "https://discord.gg";
            // 
            // BtnSetDiscordUrl
            // 
            this.BtnSetDiscordUrl.Location = new System.Drawing.Point(45, 10);
            this.BtnSetDiscordUrl.Name = "BtnSetDiscordUrl";
            this.BtnSetDiscordUrl.Size = new System.Drawing.Size(75, 31);
            this.BtnSetDiscordUrl.TabIndex = 0;
            this.BtnSetDiscordUrl.Text = "Set url";
            this.BtnSetDiscordUrl.UseVisualStyleBackColor = true;
            this.BtnSetDiscordUrl.Click += new System.EventHandler(this.BtnGoToDiscord_Click);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.textLog);
            this.tabLog.Location = new System.Drawing.Point(4, 34);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(568, 566);
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
            this.textLog.Size = new System.Drawing.Size(562, 560);
            this.textLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1302, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(715, 543);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wv);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(718, 44);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 543);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1302, 630);
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
            ((System.ComponentModel.ISupportInitialize)(this.wv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDiscord.ResumeLayout(false);
            this.tabDiscord.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
    }
}