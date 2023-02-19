namespace Aptus.Exercises;

public partial class QuadsPage : ContentPage
{
	public QuadsPage()
	{
		InitializeComponent();
	}

    void TapBarbellHackSquat(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.BarbellHackSquat());
    }
    void TapGobletSquat(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.GobletSquat());
    }
    void TapLegLunges(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.LegLunges());
    }
    void TapHorizontalLegPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.HorizontalLegPress());
    }
    void TapQuadExtensions(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.QuadExtensions());
    }
    void TapSquats(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.Squats());
    }
    void TapSeatedLegCurl(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.SeatedLegCurl());
    }
}