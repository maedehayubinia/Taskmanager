using CommunityToolkit.Maui.Views;

namespace Taskmanager;

public partial class PopUp : Popup
{
    public PopUp()
    {
        InitializeComponent();
    }
    private void PopUpButton_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Page();
        this.Close.Async();
    }
}