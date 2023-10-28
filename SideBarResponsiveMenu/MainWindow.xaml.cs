using Jamesnet.Wpf.Controls;

namespace SideBarResponsiveMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DarkThemeWindow
    {
        public MainWindow()
        {
            InitializeComponent ();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SidebarMenu.IsOpen = !SidebarMenu.IsOpen;

            if(SidebarMenu.IsOpen)
            {
                btn.Content = "SideBar Close";
            }
            if (SidebarMenu.IsOpen == false)
            {
                btn.Content = "SideBar Open";
            }
        }
    }
}
