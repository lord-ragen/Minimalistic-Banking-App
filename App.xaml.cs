using Microsoft.Maui.Controls;

namespace natmobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage(); 
        }
    }
}
