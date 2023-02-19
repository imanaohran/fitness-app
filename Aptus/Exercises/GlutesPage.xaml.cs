namespace Aptus.Exercises;

public partial class GlutesPage : ContentPage
{
	public GlutesPage()
	{
		InitializeComponent();
	}
    void TapDumbellRomanianDeadlift(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.DumbellRomanianDeadlift());
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
    void TapRomanianDeadlift(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.RomanianDeadlift());
    }
    void TapSquats(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.Squats());
    }
    void TapSumoDeadlift(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.SumoDeadlift());
    }
}