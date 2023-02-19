namespace Aptus.Exercises;

public partial class ArmsPage : ContentPage
{
	public ArmsPage()
	{
		InitializeComponent();
	}
    void TapBarbellCurls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.BarbellCurls());
    }
    void TapDumbellCurls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.DumbellCurls());
    }
    void TapEzBarCurls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.EzBarCurls());
    }
    void TapForearmCurls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.ForearmCurls());
    }
    void TapHammerCurls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.HammerCurls());
    }
    void TapSkullCrushers(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.SkullCrushers());
    }
    void TapTricepsPushDown(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.TricepsPushDown());
    }
}