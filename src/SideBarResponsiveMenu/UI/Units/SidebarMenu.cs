using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SideBarResponsiveMenu.UI.Units
{
    public class SidebarMenu : ContentControl
    {
        public Brush SelecteItemColor
        {
            get { return (Brush)GetValue (SelecteItemColorProperty); }
            set { SetValue (SelecteItemColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelecteItemColorProperty =
            DependencyProperty.Register ("SelecteItemColor", typeof (Brush), typeof (SidebarMenu), new PropertyMetadata (new SolidColorBrush((Color)ColorConverter.ConvertFromString ("#6dbddd"))));


        public ICommand SelectedItem
        {
            get { return (ICommand)GetValue (SelectedItemProperty); }
            set { SetValue (SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register ("SelectedItem", typeof (ICommand), typeof (SidebarMenu), null);


        public IEnumerable ItemSource
        {
            get { return (IEnumerable)GetValue (ItemSourceProperty); }
            set { SetValue (ItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register ("ItemSource", typeof (IEnumerable), typeof (SidebarMenu), null);


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

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate ();

            PART_ItemBoxSetting ();
        }
        ListBox ItemsBox;
        void PART_ItemBoxSetting()
        {
            var ItemsBox = GetTemplateChild ("PART_ItemsBox") as ListBox;
            if (ItemsBox == null)
                return;
            ItemsBox.SelectionChanged += (s, e) =>
            {
                this.SelectedItem?.Execute (ItemsBox.SelectedItem);
            };
            ItemsBox.SelectedIndex = 0;
        }
    }
}
