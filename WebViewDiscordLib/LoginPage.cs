using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace WebViewDiscordLib
{
    public class LoginPage  : DiscordPage
    {
        public LoginPage(WebView2 webview) : base(webview)
        {

            PageType = PageType.Login;
            _wv = webview;
            StatusMessageHandler = base.StupidDoNothingMethod;
            Initialize(webview);
        }

        private void Initialize(WebView2 webview)
        {
            base.Initialize(webview);
        }

        public static new bool PageTypeMatch()
        {
            return false;
        }
    }
}