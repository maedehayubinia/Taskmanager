namespace Taskmanager;

public partial class SubDomain : ContentPage
{
	public SubDomain()
	{
		InitializeComponent();
        LoadTasks();
    }
    private void LoadTasks()
    {
        
        for (int i = 1; i <= 10; i++)
        {
            TaskList.Children.Add(new Label { Text = $"Task {i}", Margin = new Thickness(0, 5) });
        }
    }

    private void OnTaskManagerClicked(object sender, EventArgs e)
    {
      
    }

    private void OnAppClicked(object sender, EventArgs e)
    {
      
    }

    private void OnAddTaskClicked(object sender, EventArgs e)
    {
      
        TaskList.Children.Add(new Label { Text = "New Task", Margin = new Thickness(0, 5) });
    }
}
