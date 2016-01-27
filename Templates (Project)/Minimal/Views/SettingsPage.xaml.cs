﻿using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Template10.Utils;

namespace Messaging.Views
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();

            #region App settings

            var _settings = Services.SettingsServices.SettingsService.Instance;
            RequestedTheme = _settings.AppTheme.ToElementTheme();

            #endregion
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var index = Template10.Services.SerializationService.SerializationService
                .Json.Deserialize<int>(e.Parameter?.ToString());
            MyPivot.SelectedIndex = index;
        }
    }
}