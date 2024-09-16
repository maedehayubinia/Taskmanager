namespace Taskmanager;

public partial class Groups : ContentPage
{
	public Groups()
	{
		InitializeComponent();
	}
    private async void OnAddGroupClicked(object sender, EventArgs e)
    {

        string newGroup = await DisplayPromptAsync("Add Group", "Enter group name:");

        if (!string.IsNullOrWhiteSpace(newGroup))
        {
            
        }
    }
    private async void OnAddTaskButtonClicked(object sender, EventArgs e)
    {
        

    }
}