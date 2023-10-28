using System.Windows;
using System.Windows.Controls;

namespace SideBarResponsiveMenu
{
    public class TabList : ListBox
    {
        static TabList()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (TabList), new FrameworkPropertyMetadata (typeof (TabList)));
        }
    }
}
