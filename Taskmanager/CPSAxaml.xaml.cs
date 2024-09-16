namespace Taskmanager;

public partial class CPSAxaml : ContentPage
{
	public CPSAxaml()
	{
		InitializeComponent();
	}
    private void OnAppsButtonClicked(object sender, EventArgs e)
    {
        // ???? ????? ?? ???? Apps
        await Navigation.PushAsync(new SubDomain());
       
    }
   
    }

    private void OnGamesButtonClicked(object sender, EventArgs e)
    {
        
        
    }

    private async void OnAddTaskButtonClicked(object sender, EventArgs e)
    {
   

   
    
    }
}
