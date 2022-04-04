using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Windows;
using WebViewLib;

namespace WebViewTest
{
    public partial class Form1 : Form
    {
        private Page _page;
        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void Startup()
        {
            int step = 10;
            try
            {
                _page = new Page(wv);
                step = 20;
                _page.StatusMessageHandler = Status;
                step = 30;
                _page.SaveFolder = @"C:\Users\joe\Desktop\folder\images\discord";
                step = 40;
                textImageSaveFolder.Text = _page.SaveFolder;
                step = 50;
                Environment.CurrentDirectory = _page.SaveFolder;
                step = 60;
                Status($"Set currentDirectory to {_page.SaveFolder}");
            }
            catch (Exception ex)
            {
                string msg = $"WebViewTest.Startup() @ [{step}] EXCEPTION {ex.Message}";
                Status(msg);
                System.Windows.MessageBox.Show(msg);
            }
        }

        //private void Form_Resize(object sender, EventArgs e)
        //{
        //    wv.Size = this.ClientSize - new System.Drawing.Size(wv.Location);
        //    btnGo.Left = this.ClientSize.Width - btnGo.Width;
        //    textUrl.Width = btnGo.Left - textUrl.Left;
        //}

        private void btnGo_Click(object sender, EventArgs e)
        {
            _page.NavigateTo(textUrl.Text);
        }

        private void Status(string msg)
        {
            string m = $"{DateTime.Now.ToString("yyyyMMdd hh:mm:ss.fff")} - {msg}";
            toolStripStatusLabel1.Text = m;
            textLog.AppendText(m + Environment.NewLine);
            textLog.Refresh();
        }

        private void BtnGoToDiscord_Click(object sender, EventArgs e)
        {
            textUrl.Text = "https://discord.gg";
            btnGo_Click(sender, e);
        }

        private void BtnGetTitle_Click(object sender, EventArgs e)
        {
            GetDocumentTitle();
        }

        private void GetDocumentTitle()
        {
            textDocumentTitle.Text = _page.DocumentTitle();
            textDocumentTitle.Refresh();
        }

        private void btnTakeScreenshot_Click(object sender, EventArgs e)
        {
            _page.TakeScreenshot();
        }


        private void BtnSelectImageSaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = textImageSaveFolder.Text;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textImageSaveFolder.Text = folder.SelectedPath; 
                textImageSaveFolder.Refresh();
            }
        }

        private void textImageSaveFolder_TextChanged(object sender, EventArgs e)
        {
                _page.SaveFolder = textImageSaveFolder.Text;
        }

        private void BtnOpenImageFolder_Click(object sender, EventArgs e)
        {
            int step = 10;
            try
            { 
                if (Directory.Exists(textImageSaveFolder.Text))
                {
                    step = 20;
                    // have to add "explorer.exe", where dotNet Framework did not need that 
                    Process.Start("explorer.exe", textImageSaveFolder.Text);
                }
            }
            catch (Exception ex)
            {
                string msg = $"WebViewTest.BtnOpenImageFolder_Click() @ [{step}] EXCEPTION {ex.Message}";
                Status(msg);
                System.Windows.MessageBox.Show(msg);
            }
        }
    }
}