namespace Aptus;

public partial class FemaleSettingsPage : ContentPage
{
	public FemaleSettingsPage()
	{
		InitializeComponent();
	}
    void OnProfilePageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FemaleProfilePage());
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
        Navigation.PushAsync(new FemaleFrontPage());
    }
    void OnHomePageClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FemaleMusclePage());
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