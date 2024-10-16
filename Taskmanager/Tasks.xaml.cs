using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;

namespace Taskmanager;

public partial class Tasks : ContentPage
{
    int count = 0;
    public List<TaskItem> TaskList { get; set; }

    public ObservableCollection<TaskItem> FilteredTaskItem { get; set; }

    public Tasks()
	{
		InitializeComponent();
        TaskList = new List<TaskItem>()
        {
            new TaskItem { Name = "Task 1" ,IsSelected = false},
            new TaskItem { Name = "Task 2",IsSelected = false },
            new TaskItem { Name = "Task 3",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
            new TaskItem { Name = "Task 4",IsSelected = false },
        };

        FilteredTaskItem = new ObservableCollection<TaskItem>(TaskList);

        TaskCollectionView.ItemsSource = FilteredTaskItem;

    }



    private async void OnAddTaskClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewTask());
    }
    public class TaskItem
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewTask());
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        var searchText = e.NewTextValue?.ToLower() ?? string.Empty;


        FilteredTaskItem.Clear();


        if (string.IsNullOrWhiteSpace(searchText))
        {
            foreach (var task in TaskList)
            {
                FilteredTaskItem.Add(task);
            }
        }
        else
        {

            var filteredResults = TaskList.Where(t => t.Name.ToLower().Contains(searchText));
            foreach (var task in filteredResults)
            {
                FilteredTaskItem.Add(task);
            }
        }
    }

}
public class TasksViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Task> Tasks { get; set; }

    public Command<Task> DeleteTaskCommand { get; }

    public TasksViewModel()
    {
        Tasks = new ObservableCollection<Task>();
        DeleteTaskCommand = new Command<Task>(OnDeleteTask);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnDeleteTask(Task task)
    {
        if (task != null && Tasks.Contains(task))
        {
            Tasks.Remove(task);
        }
    }

   
}
