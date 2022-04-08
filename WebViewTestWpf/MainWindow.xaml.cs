using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.IO;
using System.Windows;
using WebViewLibMF;
using System;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WebViewTestWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WebViewSettings _settings;
        private WebViewLibMF.Page _page;
        private WebViewLibMF.Page _page2;

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
                _page = new WebViewLibMF.Page(wv);
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
                InitializeTimers();
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
            _page.NavigateTo(txtUrl.Text);
        }

        private void Status(string msg)
        {
            string m = $"{DateTime.Now.ToString("yyyyMMdd hh:mm:ss.fff")} - {msg}";
            txtStatus.Text = m;
            txtLog.AppendText(m + Environment.NewLine);
            txtLog.Refresh();
        }

        private void BtnSelectImageSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.SelectedPath = txtImageSaveFolder.Text;
            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtImageSaveFolder.Text = folder.SelectedPath;
                txtImageSaveFolder.Refresh();
            }
        }

        private void wv3_Drop(object sender, System.Windows.DragEventArgs e)
        {
            int step = 10;
            try
            {
                string url = e.Data.ToString();
                txtUrl2.Text = url;
                GoButton2_Click(sender, null);
            }
            catch (Exception ex)
            {
                string msg = $"WebViewTestWpf.MainWindow.wv3_Drop() @ [{step}]{Environment.NewLine}EXCEPTION :[{ex.Message}]";
                throw new Exception(msg);
            }
        }

        private void GoButton2_Click(object sender, RoutedEventArgs e)
        {
            int step = 10;
            try
            {
                if (_page2 == null)
                {
                    step = 20;
                    _page2 = new WebViewLibMF.Page(wv2);
                    step = 30;
                    _page2.StatusMessageHandler = Status;
                }
                step = 40;
                _page2.NavigateTo(txtUrl2.Text);
            }
            catch (Exception ex)
            {
                string msg = $"WebViewTestWpf.MainWindow.wv3_Drop() @ [{step}]{Environment.NewLine}EXCEPTION :[{ex.Message}]";
                throw new Exception(msg);
            }
        }
    }

    /// Extension class to implement Refresh() for UIElements
    public static class ExtensionMethods
    {
        private static Action EmptyDelegate = delegate { };
        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }

}
