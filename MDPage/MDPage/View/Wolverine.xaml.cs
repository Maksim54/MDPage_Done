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
    public partial class Wolverine : ContentPage
    {
        public Wolverine()
        {
            InitializeComponent();
        }

        private async void wolBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://marvel.fandom.com/ru/wiki/Джеймс_Хоулетт_(1610)");
            await Browser.OpenAsync(uri);
        }
    }
}