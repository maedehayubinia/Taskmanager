using System;

namespace Taskmanager
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        string username = "maedeh";
        string password = "12345";

        private void PasswordShow (object sender, EventArgs e)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;

        }
        private void LoginButton(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(UserNameEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text))
            {
                if(UserNameEntry.Text == username && PasswordEntry.Text == password)
                {
                    App.Current.MainPage = new SmsPage();
                }
                else
                {
                    DisplayAlert("Hoooy", "Huh", "Bede sish");
                }

            }
            else
            {
                DisplayAlert("Hoooy", "Huh", "Bede sish");

            }
        }
    }

}
