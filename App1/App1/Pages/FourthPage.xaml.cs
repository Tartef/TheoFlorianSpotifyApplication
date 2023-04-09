using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Spotify_Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FourthPage : ContentPage
    {
        public FourthPage()
        {
            InitializeComponent();
            WebView.Source = SpotifyService.EmbeddedPreview("4xxLwHxyzJkg6Z002YRabT");
        }
    }
}