﻿using Microsoft.Toolkit.Uwp;
using MyPoetry.Model;
using MyPoetry.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace MyPoetry.UserControls.Pages
{
    public sealed partial class Settings : UserControl
    {
        public Settings()
        {
            this.InitializeComponent();
        }


        public class BackgroundSelector
        {
            public ImageSource BackgroundPreview { get; set; }
            public string BackgroundDescription { get; set; }

            public BackgroundSelector(Uri uri, string description)
            {
                BackgroundDescription = description;
                BackgroundPreview = new BitmapImage(uri);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            CmbLanguageSelector.Items.Clear();
            CmbBackgroundSelector.Items.Clear();

            //Automatizzare la ricerca delle lingue
            CmbLanguageSelector.Items.Add("Italiano [ITA]");
            CmbLanguageSelector.Items.Add("English [ENG]");
            CmbLanguageSelector.Items.Add("Polski [POL]");
            CmbLanguageSelector.SelectedIndex = 0;

            //Background selector
            CmbBackgroundSelector.Items.Add(new BackgroundSelector(new Uri("ms-appx:///Assets/background.png"), "Default"));
            CmbBackgroundSelector.Items.Add(new BackgroundSelector(new Uri("ms-appx:///Assets/background1.jpg"), "Azure"));
            CmbBackgroundSelector.Items.Add(new BackgroundSelector(new Uri("ms-appx:///Assets/background2.jpg"), "Dark"));
            CmbBackgroundSelector.Items.Add(new BackgroundSelector(new Uri("ms-appx:///Assets/background3.jpg"), "Blue"));
            CmbBackgroundSelector.SelectedIndex = 0;
        }


        public CustomPage GetPage { get { return MainContent; } }

        private void CmbBackgroundSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbLanguageSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
