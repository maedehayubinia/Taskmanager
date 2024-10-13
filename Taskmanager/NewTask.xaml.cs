using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using CommunityToolkit.Maui.Views;
using Microsoft.VisualBasic;
//using Intents;
namespace Taskmanager;

public partial class NewTask : ContentPage
{
	public NewTask()
	{
		InitializeComponent();
	}
    private void OnSetDeadlineClicked(object sender, EventArgs e)
    {

        DateTime selectedDate = DeadlineDatePicker.Date;

        TimeSpan selectedTime = DeadlineTimePicker.Time;

        DateTime deadline = selectedDate.Date + selectedTime;

        DeadlineLabel.Text = $"Selected Deadline: {deadline:dddd, MMMM d, yyyy h:mm tt}";
    }

    
    private void OnprerequistesButtonClicked(object sender, EventArgs e)
    {
       this.ShowPopup(new File());

    }

   
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string searchText = e.NewTextValue;
    }

    private void OnSearchButtonPressed(object sender, EventArgs e)
    {

    }
    public class Task
    {
        public string Title { get; set; }
    }

  
    private void OnTaskTypeButtonClicked(object sender, EventArgs e)
    {
       this.ShowPopup(new TaskType());

    }

    
    private async void OnSaveButtonClicked(object sender, EventArgs e)
    {

    }

    private void OnAddButtonClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new Description());

    }
}
