using code.Models;
using code.Views.DetailViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace code.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public List<MasterMenuItem> menuList
        {
            get;
            set;
        }
        public MasterPage()
        {
            InitializeComponent();
            menuList = new List<MasterMenuItem>();
            menuList.Add(new MasterMenuItem("Расписание", "open_book.png", typeof(Schedule)));
            menuList.Add(new MasterMenuItem("Заметки", "open_book.png", typeof(Notes)));
            menuList.Add(new MasterMenuItem("События", "open_book.png", typeof(Events)));
            menuList.Add(new MasterMenuItem("Домашние задания", "open_book.png", typeof(Homeworks)));
            navigationDrawerList.ItemsSource = menuList;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Schedule)));
            navigationDrawerList.ItemSelected += OnMenuItemSelected;
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterMenuItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}