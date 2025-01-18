using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace natmobile
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            var transactions = new List<Transaction>
            {
                new Transaction { Title = "Fauget Cafe", Type = "Payment", Status = "Success", StatusColor = Colors.Green, StatusIcon = "success_icon.png" },
                new Transaction { Title = "Larana, Inc.", Type = "Payment", Status = "Success", StatusColor = Colors.Green, StatusIcon = "success_icon.png" },
                new Transaction { Title = "Claudia Alves", Type = "Transfer", Status = "Failed", StatusColor = Colors.Red, StatusIcon = "failed_icon.png" },
                new Transaction { Title = "Borcelle Cafe", Type = "Payment", Status = "Success", StatusColor = Colors.Green, StatusIcon = "success_icon.png" }
            };

            TransactionsList.ItemsSource = transactions;
        }

        private void OnQRCodeClicked(object sender, EventArgs e)
        {
            // Handle QR code click event
            DisplayAlert("QR Code", "QR Code clicked!", "OK");
        }

        private async void OnRecentTransactionsTapped(object sender, EventArgs e)
        {
            // Navigate to the Transaction History Page
            await Navigation.PushAsync(new TransactionHistoryPage());
        }
    }

    public class Transaction
    {
        public required string Title { get; set; }
        public required string Type { get; set; }
        public required string Status { get; set; }
        public required Color StatusColor { get; set; }
        public string? StatusIcon { get; set; }
    }
}
