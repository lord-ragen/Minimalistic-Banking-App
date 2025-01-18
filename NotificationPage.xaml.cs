using natmobile;
namespace natmobile
{

    public partial class NotificationPage : ContentPage
    {
        public NotificationPage()
        {
            InitializeComponent();
            LoadNotifications();
        }

        // Load notifications and bind to the CollectionView
        private void LoadNotifications()
        {
            var notifications = new List<NotificationItem>
        {
            new() {
                Icon = "notification_icon.png",
                Title = "New Message",
                Message = "You have a new message from John.",
                DateTime = DateTime.Parse("2024-12-28 14:30"),
                Status = "Unread",
                StatusColor = Colors.Red
            },
            new() {
                Icon = "notification_icon.png",
                Title = "Payment Reminder",
                Message = "Your payment is due tomorrow.",
                DateTime = DateTime.Parse("2024-12-27 16:00"),
                Status = "Read",
                StatusColor = Colors.Gray
            },
            new() {
                Icon = "notification_icon.png",
                Title = "System Update",
                Message = "A system update is available.",
                DateTime = DateTime.Parse("2024-12-26 10:15"),
                Status = "Unread",
                StatusColor = Colors.Red
            }
        };

            NotificationList.ItemsSource = notifications;
        }

        // Handle the Back Button click
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // Handle the Mark All Read button click
        private void OnMarkAllReadClicked(object sender, EventArgs e)
        {
            if (NotificationList.ItemsSource is List<NotificationItem> notifications)
            {
                foreach (var notification in notifications)
                {
                    notification.Status = "Read";
                    notification.StatusColor = Colors.Gray;
                }

                NotificationList.ItemsSource = null; // Refresh the CollectionView
                NotificationList.ItemsSource = notifications; // Rebind
            }
        }

        // Handle the Sort button click
        private void OnSortButtonClicked(object sender, EventArgs e)
        {
            if (NotificationList.ItemsSource is List<NotificationItem> notifications)
            {
                var sortedNotifications = notifications
                    .OrderByDescending(n => n.DateTime)
                    .ToList();

                NotificationList.ItemsSource = null; // Refresh the CollectionView
                NotificationList.ItemsSource = sortedNotifications; // Rebind
            }
        }
    }

    // Updated NotificationItem class
    public class NotificationItem
    {
        public required string Icon { get; set; }
        public required string Title { get; set; }
        public required string Message { get; set; }
        public DateTime DateTime { get; set; }
        public required string Status { get; set; }
        public required Color StatusColor { get; set; }
    }
}