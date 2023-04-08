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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
            var spotify = SpotifyService.Spotify;
            var album = spotify.Albums.Get("7dlOxZMGwE7tIRjYXGXQtF").Result;
            Name.Text = album.Name;
            Image.Source = album.Images[0].Url;
            Artist.Text = album.Artists[0].Name;
            ReleaseDate.Text = album.ReleaseDate;
            var Tracks = album.Tracks.Items;
            TracksList.ItemsSource = Tracks;
        }
    }
}