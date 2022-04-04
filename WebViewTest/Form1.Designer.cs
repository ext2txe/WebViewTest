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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGo = new System.Windows.Forms.Button();
            this.wv = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDiscord = new System.Windows.Forms.TabPage();
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
            this.BtnOpenImageFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDiscord.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnGo);
            this.splitContainer1.Panel1.Controls.Add(this.wv);
            this.splitContainer1.Panel1.Controls.Add(this.textUrl);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1302, 604);
            this.splitContainer1.SplitterDistance = 721;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(643, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 32);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // wv
            // 
            this.wv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wv.CreationProperties = null;
            this.wv.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv.Location = new System.Drawing.Point(3, 40);
            this.wv.Name = "wv";
            this.wv.Size = new System.Drawing.Size(715, 561);
            this.wv.Source = new System.Uri("https://codaland.com/ipcheck.php", System.UriKind.Absolute);
            this.wv.TabIndex = 0;
            this.wv.ZoomFactor = 1D;
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(44, 4);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(593, 29);
            this.textUrl.TabIndex = 1;
            this.textUrl.Text = "https://codaland.com/ipcheck.php";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
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
            this.tabControl1.Size = new System.Drawing.Size(576, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDiscord
            // 
            this.tabDiscord.Controls.Add(this.BtnOpenImageFolder);
            this.tabDiscord.Controls.Add(this.BtnSelectImageSaveFolder);
            this.tabDiscord.Controls.Add(this.textImageSaveFolder);
            this.tabDiscord.Controls.Add(this.btnTakeScreenshot);
            this.tabDiscord.Controls.Add(this.textDocumentTitle);
            this.tabDiscord.Controls.Add(this.BtnGetTitle);
            this.tabDiscord.Controls.Add(this.textStartUrl);
            this.tabDiscord.Controls.Add(this.BtnSetDiscordUrl);
            this.tabDiscord.Location = new System.Drawing.Point(4, 30);
            this.tabDiscord.Name = "tabDiscord";
            this.tabDiscord.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiscord.Size = new System.Drawing.Size(568, 570);
            this.tabDiscord.TabIndex = 0;
            this.tabDiscord.Text = "Discord";
            this.tabDiscord.UseVisualStyleBackColor = true;
            // 
            // BtnSelectImageSaveFolder
            // 
            this.BtnSelectImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectImageSaveFolder.Location = new System.Drawing.Point(451, 82);
            this.BtnSelectImageSaveFolder.Name = "BtnSelectImageSaveFolder";
            this.BtnSelectImageSaveFolder.Size = new System.Drawing.Size(29, 31);
            this.BtnSelectImageSaveFolder.TabIndex = 6;
            this.BtnSelectImageSaveFolder.Text = "..";
            this.BtnSelectImageSaveFolder.UseVisualStyleBackColor = true;
            this.BtnSelectImageSaveFolder.Click += new System.EventHandler(this.BtnSelectImageSaveFolder_Click);
            // 
            // textImageSaveFolder
            // 
            this.textImageSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textImageSaveFolder.Location = new System.Drawing.Point(124, 81);
            this.textImageSaveFolder.Name = "textImageSaveFolder";
            this.textImageSaveFolder.Size = new System.Drawing.Size(321, 29);
            this.textImageSaveFolder.TabIndex = 5;
            this.textImageSaveFolder.TextChanged += new System.EventHandler(this.textImageSaveFolder_TextChanged);
            // 
            // btnTakeScreenshot
            // 
            this.btnTakeScreenshot.Location = new System.Drawing.Point(6, 82);
            this.btnTakeScreenshot.Name = "btnTakeScreenshot";
            this.btnTakeScreenshot.Size = new System.Drawing.Size(114, 31);
            this.btnTakeScreenshot.TabIndex = 4;
            this.btnTakeScreenshot.Text = "Screenshot";
            this.btnTakeScreenshot.UseVisualStyleBackColor = true;
            this.btnTakeScreenshot.Click += new System.EventHandler(this.btnTakeScreenshot_Click);
            // 
            // textDocumentTitle
            // 
            this.textDocumentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDocumentTitle.Location = new System.Drawing.Point(124, 46);
            this.textDocumentTitle.Name = "textDocumentTitle";
            this.textDocumentTitle.Size = new System.Drawing.Size(436, 29);
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
            this.textStartUrl.Size = new System.Drawing.Size(436, 29);
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
            this.tabLog.Location = new System.Drawing.Point(4, 24);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(568, 576);
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
            this.textLog.Size = new System.Drawing.Size(562, 570);
            this.textLog.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1302, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BtnOpenImageFolder
            // 
            this.BtnOpenImageFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenImageFolder.Location = new System.Drawing.Point(485, 82);
            this.BtnOpenImageFolder.Name = "BtnOpenImageFolder";
            this.BtnOpenImageFolder.Size = new System.Drawing.Size(75, 31);
            this.BtnOpenImageFolder.TabIndex = 7;
            this.BtnOpenImageFolder.Text = "Open";
            this.BtnOpenImageFolder.UseVisualStyleBackColor = true;
            this.BtnOpenImageFolder.Click += new System.EventHandler(this.BtnOpenImageFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 630);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "WebView Test";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
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
    }
}