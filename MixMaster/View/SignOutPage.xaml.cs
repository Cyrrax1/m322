namespace MixMaster.View;

public partial class SignOutPage : ContentPage
{
    public SignOutPage()
    {
        InitializeComponent();
    }



    private async void HomeClick(object sender, EventArgs e)
    {
        // Basic validation before navigating
        if (IsValidEmail(EmailEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
        {
            // Hide error message when credentials are valid
            ErrorMessageLabel.IsVisible = false;

            // Navigate to the home page
            await Shell.Current.GoToAsync("//HomePage");
        }
        else
        {
            // Display an error message
            ErrorMessageLabel.IsVisible = true;
        }
    }

    private void EntryTextChange(object sender, TextChangedEventArgs e)
    {
        bool isValidEmail = IsValidEmail(EmailEntry.Text);

        // Show or hide error message based on email validity
        ErrorMessageLabel.IsVisible = !isValidEmail;
    }

    private bool IsValidEmail(string email)
    {
        // Basic email validation
        return !string.IsNullOrEmpty(email) && email.Contains("@");
    }


}