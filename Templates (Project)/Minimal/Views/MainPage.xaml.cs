﻿using Messaging.ViewModels;
using Template10.Utils;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Messaging.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            #region App settings

            var _settings = Services.SettingsServices.SettingsService.Instance;
            RequestedTheme = _settings.AppTheme.ToElementTheme();

            #endregion
        }
    }
}