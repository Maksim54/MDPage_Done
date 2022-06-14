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
    public partial class IronMan : ContentPage
    {
        public IronMan()
        {
            InitializeComponent();
        }

        private async void imBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://marvel.fandom.com/ru/wiki/Энтони_Старк_(199999)");
            await Browser.OpenAsync(uri);
        }
    }
}