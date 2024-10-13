using System;
using Microsoft.Maui.Controls;
namespace Taskmanager;

public partial class HomePage : FlyoutPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private void OnMenuClicked(object sender, EventArgs e)
    {
        IsPresented = !IsPresented;
    }


    private async void OnHomeClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new HomePage());
        IsPresented = false; // ???? ???? ???????
    }

    private async void OnPeopleClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new MembersPage());
        IsPresented = false; // ???? ???? ???????
    }

    private async void OnDomainClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new DomainPage());
        IsPresented = false;
    }

    private async void OnTasksClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new Tasks());
        IsPresented = false;
    }
    private async void PeopleButton(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MembersPage());
    }

    private async void DomainButton(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new DomainPage());
    }

    private async void TasksButton(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Tasks());
    }
    private async void OnProfileClicked(object sender, EventArgs e)
    {
       
        Detail = new NavigationPage(new Profile());
        IsPresented = false;
    }

    private async void OnMessageClicked(object sender, EventArgs e)
    {
        Detail = new NavigationPage(new MassagePage());
        IsPresented = false;
    }
}
