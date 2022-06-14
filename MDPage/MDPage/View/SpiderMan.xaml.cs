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
    public partial class SpiderMan : ContentPage
    {
        public SpiderMan()
        {
            InitializeComponent();
        }

        private async void smBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://marvel.fandom.com/ru/wiki/Питер_Паркер_(199999)");
            await Browser.OpenAsync(uri);
        }
    }
}