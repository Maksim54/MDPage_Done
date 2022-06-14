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
    public partial class Deadpool : ContentPage
    {
        public Deadpool()
        {
            InitializeComponent();
        }

        private async void deadBut_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://marvel.fandom.com/ru/wiki/Уэйд_Уилсон_(TRN414)");
            await Browser.OpenAsync(uri);
        }
    }
}