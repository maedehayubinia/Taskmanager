using System;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace Taskmanager;

public partial class GroupPage : ContentPage
{
    private ObservableCollection<string> _groups;
    public ObservableCollection<string> FilteredGroups { get; private set; }

    public GroupPage()
    {
        InitializeComponent();
        _groups = new ObservableCollection<string>
            {
                "groupA",
                "grouB",
                "groupC",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",
                "groupD",

            };
        FilteredGroups = new ObservableCollection<string>(_groups);
        groupListView.ItemsSource = FilteredGroups;


    }
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        string searchText = searchEntry.Text?.ToLower();
        FilteredGroups.Clear();

        if (string.IsNullOrWhiteSpace(searchText))
        {
            foreach (var group in _groups)
            {
                FilteredGroups.Add(group);
            }
        }
        else
        {
            var filteredResults = _groups.Where(g => g.ToLower().Contains(searchText));
            foreach (var group in filteredResults)
            {
                FilteredGroups.Add(group);
            }
        }
    }
    public ICommand DeleteCommand { get; }


   

    

    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddGroup());
    }
}
