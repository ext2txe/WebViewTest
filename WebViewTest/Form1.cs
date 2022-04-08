using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Windows;
using WebViewLib;

namespace WebViewTest
{
    public partial class Form1 : Form
    {
        private WebViewSettings _settings;
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
                _settings = new WebViewSettings();
                step = 20;
                _page = new Page(wv);
                step = 30;
                _page.StatusMessageHandler = Status;
                step = 40;
                string userDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                step = 50;
                string saveFolder = "{userDesktop}\\folder\\images\\webviewtest";
                step = 60;
                if (!Directory.Exists(saveFolder)) Directory.CreateDirectory(saveFolder);
                step = 70;
                textImageSaveFolder.Text = saveFolder;
                step = 80;
                Environment.CurrentDirectory = saveFolder;
                step = 90;
                Status($"Set currentDirectory to {saveFolder}");
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            //show MS Edge version -- also ensures that an exception will be raised if proper MS Edge version isn't installed
            Debug.WriteLine(CoreWebView2Environment.GetAvailableBrowserVersionString());

            //initialized CorewWebView2
            await InitializeCoreWebView2Async();

            //get HTML
            string html = HelperLoadResource.ReadResource("index.html");

            //display HTML in WebView2
            wv.NavigateToString(html);
        }

        private async Task InitializeCoreWebView2Async()
        {
            //initialize CorewWebView2
            await wv.EnsureCoreWebView2Async();
        }

        private void BtnGetButton_Click(object sender, EventArgs e)
        {
            _page.ClickButtonWithInnerText(textButtonInnerText.Text);
        }

        private void wv_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            //subscribe to CoreWebView2 events (add event handlers)
            wv.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        }

        private void CoreWebView2_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            Debug.WriteLine("Info: MSG (JSON): " + e.WebMessageAsJson);
            Debug.WriteLine("Info: MSG (String): " + e.TryGetWebMessageAsString());
        }

        private void BtnNavigateToUpwork_Click(object sender, EventArgs e)
        {
            textUrl.Text = textUpworkUrl.Text;
            textUrl.Refresh();
            btnGo_Click(sender, e);
            BtnGetTitle_Click(sender, e);
        }
    }
}