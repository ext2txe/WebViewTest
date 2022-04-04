using Microsoft.Web.WebView2.Core;
using System.IO;
using System.Windows;

namespace WebViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Resize += new System.EventHandler(this.Form_Resize);
            if (wv.CoreWebView2 != null)
            {
                wv.CoreWebView2.NavigationStarting += EnsureHttps;
                wv.CoreWebView2.SourceChanged += SourceChanged;
                wv.CoreWebView2.ContentLoading += ContentLoading;
                wv.CoreWebView2.HistoryChanged += HistoryChanged;
                wv.CoreWebView2.NavigationCompleted += NavigationCompleted;
            }
        }

        private void SourceChanged(object? sender, CoreWebView2SourceChangedEventArgs e)
        {
            Status($"SourceChanged");
            textUrl.Text = $"{wv.Source.ToString()}";

        }

        private void ContentLoading(object? sender, CoreWebView2ContentLoadingEventArgs e)
        {
            Status($"ContentLoading");

        }

        private void HistoryChanged(object? sender, object e)
        {
            Status($"HistoryChanged");
        }

        private void EnsureHttps(object? sender, CoreWebView2NavigationStartingEventArgs e)
        {
            String uri = e.Uri;
            if (!uri.StartsWith("https://"))
            {
                wv.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                e.Cancel = true;
            }
        }

        private void NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            string err = $"{e.WebErrorStatus}";
            Status($"NavigationCompleted {err}");
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            wv.Size = this.ClientSize - new System.Drawing.Size(wv.Location);
            btnGo.Left = this.ClientSize.Width - btnGo.Width;
            textUrl.Width = btnGo.Left - textUrl.Left;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (wv != null && wv.CoreWebView2 != null)
            {
                Status($"navigate to {textUrl.Text}");
                wv.CoreWebView2.Navigate(textUrl.Text);
            }
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

        private async void GetDocumentTitle()
        { 
            await wv.EnsureCoreWebView2Async();
            textDocumentTitle.Text = wv.CoreWebView2.DocumentTitle.ToString();
        }

        private async void btnTakeScreenshot_Click(object sender, EventArgs e)
        {
            TakeScreenshot();
        }

        private async void TakeScreenshot()
        {
            using (MemoryStream stream = new MemoryStream())
            //using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                await wv.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
                stream.Seek(0, SeekOrigin.Begin);

                // here you can add saving to a file or copying to clipboard
                string filename = Path.Combine(textImageSaveFolder.Text, $"{DateTime.Now.ToString("hhmmssfff")}_screenshot.png");
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    stream.CopyTo(fs);
                    fs.Flush();
                }
            }
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
    }
}