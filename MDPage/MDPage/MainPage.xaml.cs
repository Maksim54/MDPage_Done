using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDPage
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("marvel.webp");
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(View.Page1);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text="Железный Человек",
                Detail="Дебют:1963г.",
                ImagePath="ironMan.jpg",
                TargetPage=typeof(View.IronMan)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Капитан Америка",
                Detail = "Дебют:1941г.",
                ImagePath = "cap.jpg",
                TargetPage = typeof(View.CaptainAmerica)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Человек-паук",
                Detail = "Дебют:1962г.",
                ImagePath = "spidey.png",
                TargetPage = typeof(View.SpiderMan)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Халк",
                Detail = "Дебют:1962г.",
                ImagePath = "Hulk.jpg",
                TargetPage = typeof(View.Hulk)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Чёрная Вдова",
                Detail = "Дебют:1964г.",
                ImagePath = "blackwidow.jpg",
                TargetPage = typeof(View.BlackWidow)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Тор",
                Detail = "Дебют:1962г.",
                ImagePath = "thor.jpg",
                TargetPage = typeof(View.Thor)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Чёрная Пантера",
                Detail = "Дебют:1966г.",
                ImagePath = "blackpanther.jpg",
                TargetPage = typeof(View.BlackPanther)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Доктор Стрейндж",
                Detail = "Дебют:1963г.",
                ImagePath = "drstr.jpg",
                TargetPage = typeof(View.DrStrange)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Росомаха",
                Detail = "Дебют:1974г.",
                ImagePath = "wolverine.jpg",
                TargetPage = typeof(View.Wolverine)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Дэдпул",
                Detail = "Дебют:1991г.",
                ImagePath = "deadpool.jpg",
                TargetPage = typeof(View.Deadpool)
            });


            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}
