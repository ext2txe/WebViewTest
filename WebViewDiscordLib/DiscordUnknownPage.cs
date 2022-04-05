using Microsoft.Web.WebView2.WinForms;

namespace WebViewDiscordLib
{
    internal class DiscordUnknownPage : DiscordPage
    {
        public DiscordUnknownPage(WebView2 webview) : base(webview)
        {
            PageType = PageType.DiscordUnknown;
        }
    }
}