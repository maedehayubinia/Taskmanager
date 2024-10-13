using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using Microsoft.VisualBasic;
//using Intents;
namespace Taskmanager;

public partial class Description : Popup
{
	public Description()
	{
		InitializeComponent();
	}
    private void PopUpButto_Clicked(object sender, EventArgs e)
    {
        //App.Current.MainPage = new NewMember();
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {

    }
    private void Button_Clicked(object sender, EventArgs e, string description)
    {

        Console.WriteLine($"Description: {description}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

}