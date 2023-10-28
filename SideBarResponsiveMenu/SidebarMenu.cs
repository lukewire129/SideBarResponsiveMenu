using System.Windows;
using System.Windows.Controls;

namespace SideBarResponsiveMenu
{
    public class SidebarMenu : ContentControl
    {
        public bool IsOpen
        {
            get { return (bool)GetValue (IsOpenProperty); }
            set { SetValue (IsOpenProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register ("IsOpen", typeof (bool), typeof (SidebarMenu), new PropertyMetadata (false));

        static SidebarMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (SidebarMenu), new FrameworkPropertyMetadata (typeof (SidebarMenu)));
        }
    }
}
