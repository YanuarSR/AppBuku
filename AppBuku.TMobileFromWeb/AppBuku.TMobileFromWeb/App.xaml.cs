﻿using AppBuku.TMobileFromWeb.Services;
using AppBuku.TMobileFromWeb.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuku.TMobileFromWeb
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // Set properties untuk aplikasi  
            this.Properties.Add("BaseWebUri", "http://appbuku.somee.com/");
            this.Properties.Add("WebUsername", "u023yanuar");
            this.Properties.Add("WebPassword", "u023yan-@aqw59");

            MainPage = new AppShell();
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
