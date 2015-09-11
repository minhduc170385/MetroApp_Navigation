using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Navigation_AppSimple
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ListBox1.DataContext = App.ArgValue;
        }


        private void Green_Click(object sender, RoutedEventArgs e)
        {
            openNextApp("simpleapp2", "", DateTime.Now.ToString());
        }
        public static async void openNextApp(string app, string action, string content)
        {
            string temp = String.Format("{0}: {1}  {2}", app, action, content);            
            var _Uri = new Uri(temp);
            await Windows.System.Launcher.LaunchUriAsync(_Uri,
            new Windows.System.LauncherOptions
            {
                DesiredRemainingView = ViewSizePreference.UseNone
            });
        }
    }
}
