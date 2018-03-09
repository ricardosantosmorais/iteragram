using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Iteragram.Pages
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
