using System.Collections.ObjectModel;

namespace Taskmanager;

public partial class DomainPage : ContentPage
{
    public ObservableCollection<TaskItem> Tasks { get; set; }

    public DomainPage()
	{
		InitializeComponent();
        Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem { Name = "Task 1" },
                new TaskItem { Name = "Task 2" },
                new TaskItem { Name = "Task 3" },
                new TaskItem { Name = "Task 4" },
                new TaskItem { Name = "Task 5" },
                new TaskItem { Name = "Task 6" },
                new TaskItem { Name = "Task 7" },
                new TaskItem { Name = "Task 8" },
                new TaskItem { Name = "Task 9" }
            };
        TaskListView.ItemsSource = Tasks;



    }
    private async void OndomainClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DomainsAndSubdomains());
    }

    
    private async void OnTaskTapped(object sender, ItemTappedEventArgs e)
    {
        var task = e.Item as TaskItem;
        if (task != null)
        {
            
            await Navigation.PushAsync(new TaskDetailPage(task.Name));
        }
    }

   
    private void OnDelete(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var task = swipeItem.BindingContext as TaskItem;
        if (task != null)
        {
            Tasks.Remove(task); 
        }
    }

  
    private void OnFavourite(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var task = swipeItem.BindingContext as TaskItem;
        if (task != null)
        {
            DisplayAlert("Favourite", $"{task.Name} marked as favourite", "OK");
        }
    }
}

internal class TaskDetailPage : Page
{
    private string name;

    public TaskDetailPage(string name)
    {
        this.name = name;
    }
}

internal class TaskListView
{
    public static ObservableCollection<TaskItem> ItemsSource { get; internal set; }
}


public class TaskItem
{
    public string Name { get; set; }
}

    