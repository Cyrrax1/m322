namespace MixMaster.View;

public partial class FaqNotificationPage : ContentPage
{
    public FaqNotificationPage()
    {
        InitializeComponent();
    }

    private async void OnCloseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
