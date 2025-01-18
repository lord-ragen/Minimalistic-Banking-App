using Microsoft.Maui.Controls;

namespace natmobile
{
    public partial class TransactionHistoryPage : ContentPage
    {
        public TransactionHistoryPage()
        {
            InitializeComponent();

            // Sample data binding
            BindingContext = new AccountOverview
            {
                Balance = "$5,500.50",
                CardNumber = "**** 1234-5678-7890",
                BankInfo = "Fauget Bank Credit Card"
            };
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Navigate back to the previous page or perform desired actions
            Navigation.PopAsync(); // Assumes you're using a NavigationPage
        }


    }

    public class AccountOverview
    {
        public required string Balance { get; set; }
        public required string CardNumber { get; set; }
        public required string BankInfo { get; set; }
    }
}
