using Microsoft.Web.WebView2.WinForms;

namespace WebViewDiscordLib
{
    internal class DiscordController
    {
        public static DiscordPage IdentifyDiscordPage(WebView2 webview)
        {
            // assume that we're dealing with an unknown page
            DiscordUnknownPage unknownPage = new DiscordUnknownPage(webview);

            if (LoginPage.PageTypeMatch())
            {
                LoginPage loginPage = new LoginPage(webview);
                return (DiscordPage) loginPage;
            }

            return (DiscordPage) unknownPage;
        }
    }
}
