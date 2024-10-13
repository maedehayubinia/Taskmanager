using CommunityToolkit.Maui.Views;

namespace Taskmanager;

public partial class FileProfile : Popup
{
   

    public FileProfile()
	{
		InitializeComponent();
	}
    private async void OnSelectPhotoFileClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Select a file"

            });

            if (result != null)
            {
                prerequisteLbel.Text = $"Selected file: {result.FileName}";
            }


        }
        catch (Exception ex)
        {
            prerequisteLbel.Text = $"Error picking file: {ex.Message}";
        }



    }
    private async void PopUpButto_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Profile();
    }


}