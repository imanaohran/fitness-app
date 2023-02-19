namespace Aptus.Exercises;

public partial class LegsPage : ContentPage
{
	public LegsPage()
	{
		InitializeComponent();
	}

    void TapBarbellHackSquat(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.BarbellHackSquat());
    }

    void TapCalvesRaisers(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.CalvesRaisers());
    }

    void TapRomanianDeadlift(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.RomanianDeadlift());
    }

    void TapGobletSquat(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.GobletSquat());
    }

    void TapHamstringCurls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.HamstringCurls());
    }

    void TapHorizontalLegPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.HorizontalLegPress());
    }

    void TapSquats(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.Squats());
    }

    void TapQuadExtensions(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.QuadExtensions());
    }

    void TapSumoDeadlift(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.SumoDeadlift());
    }


}