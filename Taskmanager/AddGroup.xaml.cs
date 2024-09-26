using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
//using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Taskmanager;

public partial class AddGroup : ContentPage
{
    public ObservableCollection<Member> Members { get; set; }
    public AddGroup()
    {
        InitializeComponent();
        Members = new ObservableCollection<Member>
            {
                new Member { Name = "User1" },
                new Member { Name = "User2" },
                new Member { Name = "User3" },
                 new Member { Name = "User3" },
                  new Member { Name = "User3" },
                   new Member { Name = "User3" },
               new Member { Name = "User3" }
            };

        // ???? ???? ?? ?? CollectionView ???? ???????
        membersCollectionView.ItemsSource = Members;
    }
    private void OnShowMembersButtonClicked(object sender, EventArgs e)
    {
       
        membersFrame.IsVisible = !membersFrame.IsVisible;

    }
    private void OnAddGroupsButtonClicked(object sender, EventArgs e)
    {

        

       
    }
    private void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var selectedMembers = Members.Where(m => m.IsSelected).ToList();

        if (!string.IsNullOrWhiteSpace(groupNameEntry.Text) && !string.IsNullOrWhiteSpace(groupidEntry.Text) && selectedMembers.Any())
        {
            // ????? ????????? ???? ?? ????? ?? ????? ?????? ??? ????? ????
            DisplayAlert("Group Saved", $"Group '{groupNameEntry.Text}' with {selectedMembers.Count} members added.", "OK");

            // ???? ???? ???? ???? ?? ?? ?????
            membersFrame.IsVisible = false;

            // ????? ?????? ???? Show Members
            showMembersButton.IsVisible = true;
        }
        else
        {
            DisplayAlert("Error", "Please enter group details and select at least one member.", "OK");
        }
    }
    private void OnSaveGroupButtonClicked(object sender, EventArgs e)
    {
        // Handle the final group creation logic
        string groupName = groupNameEntry.Text;
        string groupId = groupidEntry.Text;

        // Add your logic to create the group with selected members
        // e.g., saving to a database, making an API call, etc.
    }

    public class Member
{
    public string Name { get; set; }
    public bool IsSelected { get; set; }
}
}


