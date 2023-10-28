using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using System.Collections.Generic;

namespace SideBarResponsiveMenu.ViewModels
{
    public class DataModel
    {
        public IconType IconType { get; set; }
        public string Name { get; set; }

        public DataModel(IconType type, string name)
        {
            this.IconType = type;
            this.Name= name;
        }
    }
    public partial class MainViewModel :ObservableBase
    {
        [ObservableProperty] List<DataModel> _sampleDatas;

        public MainViewModel()
        {
            this.SampleDatas = new List<DataModel> ();
            this.SampleDatas.Add (new DataModel( IconType.Home, "Home"));
            this.SampleDatas.Add (new DataModel (IconType.Account, "Profile"));
            this.SampleDatas.Add (new DataModel( IconType.Comment, "Messages"));
            this.SampleDatas.Add (new DataModel (IconType.Cog, "Settings"));
            this.SampleDatas.Add (new DataModel (IconType.Youtube, "Help"));
            this.SampleDatas.Add (new DataModel (IconType.Security, "Password"));
            this.SampleDatas.Add (new DataModel (IconType.Microsoft, "Sign Out"));
        }
    }
}
