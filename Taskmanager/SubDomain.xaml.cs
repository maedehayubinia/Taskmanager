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
            
        }
    }

    private async void OnTaskManagerClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Groups());
    }

    private void OnAppClicked(object sender, EventArgs e)
    {

    }

    private void OnAddTaskButtonClicked(object sender, EventArgs e)
    {

        
    }
}



   