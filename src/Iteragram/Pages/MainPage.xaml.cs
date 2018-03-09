using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Iteragram.Pages
{
    public partial class MainPage : ContentPage
    {
        private String access_token = "46966167.5a23238.63f216382a8544fdacfb53c8a566d1ce";

        public MainPage()
        {
            InitializeComponent();
            Init();
        }

        public void Init() {

            btnSearch.Clicked += (object sender, EventArgs e) =>
            {
                Navigation.PushAsync(new UserPage());
            };
        }
    }
}
