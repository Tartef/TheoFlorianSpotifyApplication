using SpotifyAPI.Web;

namespace App1.Spotify_Service
{
    public static class SpotifyService
    {
        public static SpotifyClient Spotify { get; }

        static SpotifyService()
        {
            var spotify = new SpotifyClient("METTRE SON TOKEN ICI");
            Spotify = spotify;
        }
    }
}