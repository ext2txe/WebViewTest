using System;
using System.Windows.Threading;

namespace WebViewTestWpf
{
    public partial class MainWindow
    {
        private DispatcherTimer _timer = new DispatcherTimer();

        private void InitializeTimers()
        {
            _timer.Interval = new TimeSpan(0, 0, 0, 1);
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            UpdateCurrentTime();
        }

        private void UpdateCurrentTime()
        {
            lblCurrentTime.Content = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentTime.Refresh();
        }
    }
}
