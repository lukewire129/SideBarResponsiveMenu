using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Location;
using SideBarResponsiveMenu.ViewModels;
using System.Windows;

namespace SideBarResponsiveMenu
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow ();
        }

        protected override void RegisterWireDataContexts(ViewModelLocatorCollection items)
        {
            base.RegisterWireDataContexts (items);
            items.Register<MainWindow, MainViewModel> ();
        }
    }
}
