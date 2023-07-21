﻿using Cinepolis.Effects;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinepolis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CursorColorEffect), typeof(CursorColorEffect));
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}