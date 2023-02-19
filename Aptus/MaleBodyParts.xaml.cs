namespace Aptus;

public partial class MaleBodyParts : ContentPage
{
	public MaleBodyParts()
	{
		InitializeComponent();
	}
    void TapChest(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.ChestPage());
    }

    void TapBack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.BackPage());
    }

    void TapLegs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.LegsPage());
    }
    void TapShoulders(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.ShouldersPage());
    }
    void TapArms(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.ArmsPage());
    }
}