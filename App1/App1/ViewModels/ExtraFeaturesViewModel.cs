using System.Threading.Tasks;
using App1.Spotify_Service;
using SpotifyAPI.Web;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ExtraFeaturesViewModel: BaseViewModel
    {
        private HtmlWebViewSource _htmlSource;
        public HtmlWebViewSource HtmlSource
        {
            get => GetValue<HtmlWebViewSource>();
            set => SetValue(value);
        }
        
        private FullPlaylist _playlist;
        public FullPlaylist Playlist
        {
            get => GetValue<FullPlaylist>();
            set => SetValue(value);
        }
        
        public ExtraFeaturesViewModel()
        {
            HtmlSource = SpotifyService.EmbeddedPreview("1WgXqy2Dd70QQOU7Ay074N");
        }
        
        public async Task LoadData()
        {
            Playlist = await SpotifyService.Spotify.Playlists.Get("37i9dQZF1DZ06evO15Ttp6");
            // var bip = Playlist.Tracks.Items[0].Track;
            // Playlist.Tracks.Items[0]
            
        }
    }
}