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
    public partial class DrStrange : ContentPage
    {
        public DrStrange()
        {
            InitializeComponent();
        }

        private async void docBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://marvel.fandom.com/ru/wiki/Стефан_Стрэндж_(199999)");
            await Browser.OpenAsync(uri);
        }
    }
}