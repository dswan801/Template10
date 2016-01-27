﻿using Messaging.ViewModels;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;
using Template10.Utils;

namespace Messaging.Views
{
    public sealed partial class DetailPage : Page
    {
        public DetailPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;

            #region App settings

            var _settings = Services.SettingsServices.SettingsService.Instance;
            RequestedTheme = _settings.AppTheme.ToElementTheme();

            #endregion
        }
    }
}
