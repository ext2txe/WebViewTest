using Microsoft.Web.WebView2.Core;

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
            Status($"SouorceChanged");
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

    }
}