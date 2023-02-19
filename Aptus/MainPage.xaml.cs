using System.Runtime.CompilerServices;


namespace Aptus;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();
    }
    private void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage(), true);
        NavigateButtSn.BorderWidth = 0;
    }
}


