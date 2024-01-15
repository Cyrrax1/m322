using System;
using Microsoft.Maui.Controls;

namespace MixMaster.View
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private async void OnFaqButtonClicked(object sender, EventArgs e)
        {
            var faqPage = new FaqNotificationPage(); // Assuming FaqNotificationPage is your modal page
            await Navigation.PushModalAsync(faqPage);
        }
    }
}
