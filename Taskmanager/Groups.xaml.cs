namespace Taskmanager;

public partial class Groups : ContentPage
{
	public Groups()
	{
		InitializeComponent();
	}
    private async void OnAddGroupClicked(object sender, EventArgs e)
    {
        // ???? ???? ????? ???? ???? ????
        string newGroup = await DisplayPromptAsync("Add Group", "Enter group name:");
       
        if (!string.IsNullOrWhiteSpace(newGroup))
        {
            GroupsList.Children.Add(new Label { Text = newGroup, Padding = 10, });
        }
    }

    private async void OnAddTaskClicked(object sender, EventArgs e)
    {
        
        string newTask = await DisplayPromptAsync("Add Task", "Enter task name:");
        if (!string.IsNullOrWhiteSpace(newTask))
        {
            TasksList.Children.Add(new Label { Text = newTask, Padding = 10, });
        }
    }

   }
   
