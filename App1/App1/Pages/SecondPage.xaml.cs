using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Spotify_Service;
using App1.ViewModels;
using SpotifyAPI.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        private ArtistViewModel _viewModel;
        public SecondPage()
        {
            InitializeComponent();
            // var artist = SpotifyService.Spotify.Artists.Get("1WgXqy2Dd70QQOU7Ay074N").Result;
            // Name.Text = artist.Name;
            // Followers.Text = artist.Followers.Total.ToString() + " followers";
            // Image.Source = artist.Images[0].Url;
            // Genres.Text = "Genres: ";
            // foreach (var genre in artist.Genres)
            // {
            //     Genres.Text += genre + ", ";
            // }
            // Popularity.Text = "Rang: " + artist.Popularity;
            _viewModel = new ArtistViewModel();
            BindingContext = _viewModel;
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadData();
        }
    }
}