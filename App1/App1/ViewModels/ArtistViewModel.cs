using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using App1.Spotify_Service;

namespace App1.ViewModels
{
    public class ArtistViewModel: INotifyPropertyChanged
    {
        private string _followers;
        public string Followers
        {
            get => _followers;
            set => SetProperty(ref _followers, value);
        }

        private string _imageSource;
        public string ImageSource
        {
            get => _imageSource;
            set => SetProperty(ref _imageSource, value);
        }

        private string _genres;
        public string Genres
        {
            get => _genres;
            set => SetProperty(ref _genres, value);
        }

        private string _popularity;
        public string Popularity
        {
            get => _popularity;
            set => SetProperty(ref _popularity, value);
        }
        
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public async Task LoadData()
        {
            var artist = await SpotifyService.Spotify.Artists.Get("1WgXqy2Dd70QQOU7Ay074N");
            Name = artist.Name;
            Followers = artist.Followers.Total.ToString() + " followers";
            ImageSource = artist.Images[0].Url;
            Genres = "Genres: " + string.Join(", ", artist.Genres);
            Popularity = "Rang: " + artist.Popularity;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return;

            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyName);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}