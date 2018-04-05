using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace EFTuts.Shell.MyApp.Views.Splashscreens
{
    /// <summary>
    /// Interaction logic for SplashWindow.xaml
    /// </summary>
    public partial class SplashWindow : Window
    {
        Thread loadingThread;
        Storyboard Showboard;
        Storyboard Hideboard;
        private delegate void ShowDelegate(string txt);
        private delegate void HideDelegate();
        ShowDelegate showDelegate;
        HideDelegate hideDelegate;

        public SplashWindow()
        {
            InitializeComponent();
            showDelegate = new ShowDelegate(this.showText);
            hideDelegate = new HideDelegate(this.hideText);
            Showboard = this.Resources["showStoryBoard"] as Storyboard;
            Hideboard = this.Resources["HideStoryBoard"] as Storyboard;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadingThread = new Thread(load);
            loadingThread.Start();
        }
        private void load()
        {
            Thread.Sleep(1800);
            this.Dispatcher.Invoke(showDelegate, "Loading Data Sample-1...");
            Thread.Sleep(2000);
            //load data 
            this.Dispatcher.Invoke(hideDelegate);

            Thread.Sleep(1800);
            this.Dispatcher.Invoke(showDelegate, "Loading Data Sample-2...");
            Thread.Sleep(2000);
            //load data
            this.Dispatcher.Invoke(hideDelegate);

            Thread.Sleep(1800);
            this.Dispatcher.Invoke(showDelegate, "Loading Data Sample-3...");
            Thread.Sleep(2000);
            //load data
            this.Dispatcher.Invoke(hideDelegate);


            Thread.Sleep(1800);
            this.Dispatcher.Invoke(showDelegate, "Finalizing...");
            Thread.Sleep(2000);
            //load data 
            this.Dispatcher.Invoke(hideDelegate);



            //close the window
            Thread.Sleep(2000);
            this.Dispatcher.Invoke(DispatcherPriority.Normal,
                (Action)delegate () { Close(); });
        }
        private void showText(string txt)
        {
            txtLoading.Text = txt;
            BeginStoryboard(Showboard);
        }
        private void hideText()
        {
            BeginStoryboard(Hideboard);
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Closing -= Window_Closing;
            e.Cancel = true;
            var anim = new DoubleAnimation(0, (Duration)TimeSpan.FromSeconds(1));
            anim.Completed += (s, _) => this.Close();
            this.BeginAnimation(UIElement.OpacityProperty, anim);
        }
    }
}
