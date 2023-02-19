namespace Aptus;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
    void OnProfilePageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProfilePage());
    }
    void OnChangePasswordClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FemaleProfilePage());
    }
    void OnWorkoutPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WorkoutPage());
    }
    void OnCarouselPageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MaleFrontPage());
    }
    void OnHomePageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TabbedPage());
    }
    void OnAboutUsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AboutUsPage());
    }
    void OnLogOutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LoginPage());

    }
}