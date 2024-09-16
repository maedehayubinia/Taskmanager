namespace Taskmanager;

public partial class GroupPage : ContentPage
{
	public GroupPage()
	{
		InitializeComponent();
	}
    private void OnCPSAButtonClicked(object sender, EventArgs e)
    { 
       
        DisplayAlert("CPSA", "CPSA button clicked!", "OK");
        
        
         await Navigation.PushAsync(new CPSA());
        
    }


    private void OnNextCompanyButtonClicked(object sender, EventArgs e)
    {
        
        
        DisplayAlert("Next Company", "Next Company button clicked!", "OK");
    }

    private async void OnAddTaskButtonClicked(object sender, EventArgs e)
    {
       
        string taskName = await DisplayPromptAsync("Add Task", "Enter task name:");
        if (!string.IsNullOrEmpty(taskName))
        {
            TasksStack.Children.Add(new Label { Text = taskName, Padding = 10 });
        }
    }
}
