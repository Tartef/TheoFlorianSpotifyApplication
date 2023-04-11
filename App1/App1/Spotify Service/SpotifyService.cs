using System;
using SpotifyAPI.Web;
using Xamarin.Forms;

namespace App1.Spotify_Service
{
    public static class SpotifyService
    {
        public static SpotifyClient Spotify { get; }

        static SpotifyService()
        {
            var config = SpotifyClientConfig.CreateDefault();
            var request =
                new ClientCredentialsRequest("3fce54660a8f43b1a1dbb8be575f5ed1", "03b44679af924110892c3905531fda71");
            var response = new OAuthClient(config).RequestToken(request).Result;
            var spotify = new SpotifyClient(config.WithToken(response.AccessToken));
            Spotify = spotify;
        }

        public static HtmlWebViewSource EmbeddedPreview(String trackId)
        {
            var html =
                @"<html><body><iframe style='border-radius:12px' src='https://open.spotify.com/embed/track/"
                + trackId
                + "?utm_source=generator' width='100%' height='152' frameBorder='0' allowfullscreen='' " +
                "allow='autoplay; clipboard-write; encrypted-media; fullscreen; picture-in-picture' loading='lazy'>" +
                "</iframe></body></html>";
            var htmlWebViewSource = new HtmlWebViewSource();
            htmlWebViewSource.Html = html;
            return htmlWebViewSource;
        }
    }
}