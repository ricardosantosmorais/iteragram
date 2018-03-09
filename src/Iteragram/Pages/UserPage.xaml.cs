using System;
using System.Collections.Generic;
using Iteragram.Services;
using Xamarin.Forms;

namespace Iteragram.Pages
{
    public partial class UserPage : ContentPage
    {
        private UserApiClient _userApiClient;
        
        public UserPage()
        {
            InitializeComponent();
            Clicks();
            Init();
        }

        protected void Clicks() {

            btnBack.Clicked += (object sender, EventArgs e) =>
            {
                Application.Current.MainPage.Navigation.PopAsync();
            };
        }

        protected async void Init()
        {
            _userApiClient = new UserApiClient();
            var result = await _userApiClient.GetClient();
            if (result.Success)
            {
                List<Iteragram.Models.Image> images = new List<Iteragram.Models.Image>();
                foreach(var item in result.Data.Data) {
                    images.Add(item.images);
                }
                actInd.IsVisible = false;
                actInd.IsRunning = false;
                FillPhotos(images);
            }
        }

        protected void FillPhotos(List<Iteragram.Models.Image> images) {

            var grid = new Grid();
            grid.Margin = new Thickness(0, 100, 0, 0);
            grid.RowSpacing = 0;
            grid.ColumnSpacing = 0;
            var columns = 3;
            if (images.Count < 3)
                columns = images.Count;

            for (var i = 0; i < Math.Round((double)images.Count/columns);i++) {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(150) });
            }

            for (var i = 0; i < columns; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(150) });
            }

            var countRows = 0;
            var countColumns = 0;

            for (var i = 0; i < images.Count; i++)
            {
                var image = images[i];
                grid.Children.Add(new Image { Source = ImageSource.FromUri(new Uri(image.LowResolution.Url)) }, countColumns, countRows);
                countColumns++;
                if(countColumns == 3) {
                    countColumns = 0;
                    countRows++;
                }
            }

            container.Children.Add(grid);
        }
    }
}
