using Microsoft.Maui.Controls;

namespace natmobile
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnGetStartedClicked(object sender, EventArgs e)
        {
            WelcomePage.IsVisible = false;
            LoginStackLayout.IsVisible = true;

        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Simulate login success
            await DisplayAlert("Login", "Login successful!", "OK");

            // Navigate to the HomePage
            Application.Current.MainPage = new AppShell();
        }

        private void OnSignUpTapped(object sender, EventArgs e)
        {
            LoginStackLayout.IsVisible = false;
            SignUpPage.IsVisible = true;
        }

        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            //Simulate account creation
            await DisplayAlert("Sign Up", "Account created successfully.", "OK");

            //Navigate to Homepage
            Application.Current.MainPage= new AppShell();
        }
    }
}
