using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace WebViewLib
{
    public class Page
    {
        /// <summary>
        /// configure handler for delegate to receive status messages from this class
        /// </summary>
        /// <param name="message"></param>
        public delegate void StatusMessageDelegate(string message);
        public StatusMessageDelegate StatusMessageHandler { get; set; }

        private WebView2 _wv;

        private string _saveFolder = "";
        /// <summary>
        /// folder where screenshots are to be saved
        /// </summary>
        public string SaveFolder { get =>_saveFolder; set => SetSaveFolder(value); } 

        private void SetSaveFolder(string value)
        {
            if (!Directory.Exists(value))
            {
                Directory.CreateDirectory(value);
                Status($"SetSaveFolder() create folder {value}");
            }
            _saveFolder = value;
        }

        /// <summary>
        /// placeholder for webview application - project specific page type enum
        /// </summary>
        public string PageType { get; set; }
        
        /// <summary>
        /// find a better way to handle nullable delegate,
        /// for now set status message handler to this initially
        /// </summary>
        /// <param name="message"></param>
        private void StupidDoNothingMethod(string message) {}

        public Page(WebView2 webView)
        {
            PageType = "default";
            _wv = webView;
            StatusMessageHandler = StupidDoNothingMethod;
            Initialize(webView);
        }

        private async void Initialize(WebView2 webview)
        {
            int step = 10;
            try
            {
                await _wv.EnsureCoreWebView2Async();

                _wv.CoreWebView2.NavigationStarting += EnsureHttps;
                _wv.CoreWebView2.SourceChanged += SourceChanged;
                _wv.CoreWebView2.ContentLoading += ContentLoading;
                _wv.CoreWebView2.HistoryChanged += HistoryChanged;
                _wv.CoreWebView2.NavigationCompleted += NavigationCompleted;

            }
            catch (Exception ex)
            {
                string msg = $"WebViewLib.Page() @ [{step}] EXCEPTION {ex.Message}";
                Status(msg);
                throw new Exception(msg);
            }
        }

        private void Status(string message)
        {
            if (StatusMessageHandler != StupidDoNothingMethod)
            {
                StatusMessageHandler(message);
            }
        }

        private void SourceChanged(object? sender, CoreWebView2SourceChangedEventArgs e)
        {
            Status($"SourceChanged");
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
                _wv.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                e.Cancel = true;
            }
        }

        public void NavigateTo(string url)
        {
            _wv.CoreWebView2.Navigate(url);
            Status($"navigate to {url}");
        }

        public string DocumentTitle()
        {
            return _wv.CoreWebView2.DocumentTitle;
        }

        private void NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            string err = $"{e.WebErrorStatus}";
            Status($"NavigationCompleted {err}");
        }

        public async void TakeScreenshot()
        {
            using (MemoryStream stream = new MemoryStream())
            //using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            {
                await _wv.CoreWebView2.CapturePreviewAsync(CoreWebView2CapturePreviewImageFormat.Png, stream);
                stream.Seek(0, SeekOrigin.Begin);

                // here you can add saving to a file or copying to clipboard
                string filename = Path.Combine( SaveFolder, $"{DateTime.Now.ToString("hhmmssfff")}_screenshot.png");
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    stream.CopyTo(fs);
                    fs.Flush();
                }
            }
        }


    }
}