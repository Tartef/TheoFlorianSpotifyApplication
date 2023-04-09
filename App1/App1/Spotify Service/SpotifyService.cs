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
            var spotify = new SpotifyClient("METTRE SON TOKEN ICI");
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