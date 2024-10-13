using Microsoft.Maui.Controls;
using System.Collections.Generic;
namespace Taskmanager;

public partial class AddUserPage : ContentPage
{
    private string selectedGroup;

    public AddUserPage()
	{
		InitializeComponent();
	}
    private async void OnSelectGroupClicked(object sender, EventArgs e)
    {
      
        var groups = new List<string>()
            {
                "Group A",
                "Group B",
                "Group C",
                
            };

        // ????? ???? ??????? ?? ???? ??? ??
        var result = await DisplayActionSheet("Select Group", "Cancel", null, groups.ToArray());
        if (result != "Cancel")
        {
            selectedGroup = result;
            groupButton.Text = selectedGroup; // ????? ??? ???? ?????? ??? ?? ??? ????
        }
    }

    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        
        var username = usernameEntry.Text;
        var password = passwordEntry.Text;

      
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(selectedGroup))
        {
            await DisplayAlert("Error", "Please fill all fields.", "OK");
            return;
        }

       
        var newUser = new Member { Username = username, Password = password, Group = selectedGroup };
        

        await DisplayAlert("Success", "User added successfully!", "OK");

       
        await Navigation.PopAsync();
    }
    private async void OnSelectDominClicked(object sender, EventArgs e)
    {
       
       await Navigation.PushAsync(new DomainPage());

    }
}

