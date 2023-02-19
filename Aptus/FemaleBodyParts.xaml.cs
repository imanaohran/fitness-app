namespace Aptus;

public partial class FemaleBodyParts : ContentPage
{
	public FemaleBodyParts()
	{
		InitializeComponent();
	}

    void TapGlutes(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.GlutesPage());
    }

    void TapBack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.BackPage());
    }

    void TapQuads(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.QuadsPage());
    }
    void TapHamstrings(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.HamstringsPage());
    }
    void TapArms(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Exercises.ArmsPage());
    }
}