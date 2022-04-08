using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Windows;
using WebViewLib;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WebViewTestWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WebViewSettings _settings;

        public MainWindow()
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
                txtImageSaveFolder.Text = saveFolder;
                step = 80;
                Environment.CurrentDirectory = saveFolder;
                step = 90;
                //Status($"Set currentDirectory to {saveFolder}");
                
            }
            catch (Exception ex)
            {
                string msg = $"WebViewTest.Startup() @ [{step}] EXCEPTION {ex.Message}";
                //Status(msg);
                System.Windows.MessageBox.Show(msg);
            }
        }


        private void txtUrl_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
