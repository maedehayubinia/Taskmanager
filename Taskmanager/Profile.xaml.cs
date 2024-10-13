using CommunityToolkit.Maui.Views;

namespace Taskmanager;

public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();
    }
    private void OnEditProfilePictureClicked(object sender, EventArgs e)
    {

        DisplayAlert("Edite profile", "Editing", "Ok");
        this.ShowPopup(new FileProfile());
    }


    private void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        DisplayAlert("Exit", "...", "OK");

        // Application.Current.MainPage = new LoginPage();
    }
    private void OnSaveProfileButtonClicked(object sender, EventArgs e)
    {

    }
    

}
