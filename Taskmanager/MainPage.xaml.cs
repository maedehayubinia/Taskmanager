﻿namespace Taskmanager
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
           // MainPage = new NavigationPage(new HomePage());

        }

        string username = "m";
        string password = "8282";

        

        private void PasswordShow(object sender, EventArgs e)
        {
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }
        private void LoginButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                if (userNameEntry.Text == username && passwordEntry.Text == password)
                {
                    App.Current.MainPage = new SmsPage();
                }
                else
                {
                    DisplayAlert("Heey", "Something wrong", "...");
                }

                App.Current.MainPage = new SmsPage();
            }
            else
            {
                DisplayAlert("Heey", "Something wrong", "...");
            }
        }
    }
}