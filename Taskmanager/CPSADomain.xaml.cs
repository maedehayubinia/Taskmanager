namespace Taskmanager;

public partial class CPSADomain : ContentPage
{
	public CPSADomain()
	{
		InitializeComponent();
	}
    private async void OnAppsButtonClicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new SubDomain());

    }
    private void OnGamesButtonClicked(object sender, EventArgs e)
    {

    }
    private void OnAddTaskButtonClicked(object sender, EventArgs e)
    {

    }





}






