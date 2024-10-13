using CommunityToolkit.Maui.Views;

namespace Taskmanager;

public partial class TaskType : Popup
{
    private List<TaskItem> tasks;
    public List<TaskItem> TaskList { get; set; }
    public TaskType()
    {
        InitializeComponent();
        tasks = new List<TaskItem>();
        {
            new TaskItem { Title = "Task 1", IsSelected = false };
            new TaskItem { Title = "Task 2", IsSelected = false };
            new TaskItem { Title = "Task 3", IsSelected = false };
        };
        TasksCollectionView.ItemsSource = tasks;


    }
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsSelected { get; set; }
    }
    private async void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NewTask();
    }
}