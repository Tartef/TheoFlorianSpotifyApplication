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
    public partial class FourthPage : ContentPage
    {
        private ExtraFeaturesViewModel _viewModel;
        public FourthPage()
        {
            InitializeComponent();
            _viewModel = new ExtraFeaturesViewModel();
            //BindingContext = _viewModel;
            //TracksList.ItemsSource = _viewModel.Playlist.Tracks.Items;
            WebView.Source = SpotifyService.EmbeddedPreview("4xxLwHxyzJkg6Z002YRabT");
            var playlist = SpotifyService.Spotify.Playlists.Get("37i9dQZF1DZ06evO15Ttp6").Result.Tracks.Items;
            TracksList.ItemsSource = playlist.Select(t => t.Track);
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadData();
        }
        
        private void OnTrackTapped(object sender, ItemTappedEventArgs e)
        {
            // Récupérer l'objet Track sélectionné
            var selectedTrack = e.Item as FullTrack;

            // Vérifier que l'objet n'est pas nul
            if (selectedTrack != null)
            {
                // Appeler votre fonction avec l'ID de la Track en paramètre
                WebView.Source = SpotifyService.EmbeddedPreview(selectedTrack.Id);
            }

            // Désélectionner l'élément sélectionné
            ((ListView)sender).SelectedItem = null;
        }
    }
}