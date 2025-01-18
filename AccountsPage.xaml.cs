using System.Collections.ObjectModel;

namespace natmobile;

public partial class AccountsPage : ContentPage
{
    public ObservableCollection<AccountCard> AccountCards { get; set; }

    public AccountsPage()
    {
        InitializeComponent();

        // Populate sample data for accounts
        AccountCards =
        [
            new() {
                Balance = "$5,500.50\nBalance",
                CardNumber = "**** 123-456-7890",
                BankInfo = "Fauget Bank\nCredit Card"
            },
            new() {
                Balance = "$1,200.00\nBalance",
                CardNumber = "**** 987-654-3210",
                BankInfo = "Fauget Bank\nSavings Account"
            },
            new() {
                Balance = "$300.00\nBalance",
                CardNumber = "**** 654-321-0987",
                BankInfo = "Other Bank\nDebit Card"
            }
        ];

        // Bind the data to the view
        BindingContext = this;
    }
}

public class AccountCard
{
    public required string Balance { get; set; }
    public required string CardNumber { get; set; }
    public required string BankInfo { get; set; }
}
