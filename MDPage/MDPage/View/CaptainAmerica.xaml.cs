using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDPage.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CaptainAmerica : ContentPage
    {
        public CaptainAmerica()
        {
            InitializeComponent();
        }

        private async void capBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://marvel.fandom.com/ru/wiki/Стивен_Роджерс_(199999)");
            await Browser.OpenAsync(uri);
        }
    }
}