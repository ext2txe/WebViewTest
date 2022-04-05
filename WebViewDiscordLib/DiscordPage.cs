using Microsoft.Web.WebView2.WinForms;
using System.Diagnostics;
using WebViewLib;

namespace WebViewDiscordLib
{
    public abstract class DiscordPage : Page
    {
        public PageType PageType { get; set; } = PageType.DiscordUnknown;

        public DiscordPage(WebView2 webview) : base(webview)
        {

        }

        public static  bool PageTypeMatch()
        {
            throw new NotImplementedException();
        }

        private async Task ClickWebView2ButtonByInnerText(string btnInnerText)
        {
            if (_wv != null && _wv.CoreWebView2 != null)
            {
                string jsCode = HelperLoadResource.ReadResource("TestButtonClick.js");
                jsCode += System.Environment.NewLine;
                jsCode += "clickDesiredButtonByInnerText('" + btnInnerText + "');";

                var result = await _wv.CoreWebView2.ExecuteScriptAsync(jsCode);

                Debug.WriteLine("result: " + result);
            }
        }

    }
}
