using Microsoft.Maui.Controls;
using System;

namespace MixMaster.View
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void OnSwitchToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                // Benachrichtigungen sind aktiviert
                DisplayAlert("Benachrichtigungen", "Du bekommst ab sofort Benachrichtigungen.", "OK");
            }
            else
            {
                // Benachrichtigungen sind deaktiviert
                DisplayAlert("Benachrichtigungen", "Du bekommst keine Benachrichtigungen mehr.", "OK");
            }
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            int volume = (int)e.NewValue;
            volumeLabel.Text = $"{volume}%";
        }

    }
}
