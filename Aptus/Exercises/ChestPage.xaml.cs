namespace Aptus.Exercises;

public partial class ChestPage : ContentPage
{
	public ChestPage()
	{
		InitializeComponent();
	}
    void TapBenchPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.BenchPress());
    }
    void TapInclineBenchPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.InclineBenchPress());
    }

    void TapDeclinePress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.DeclinePress());
    }

    void TapDumbellFlyes(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.DumbellFlyes());
    }

    void TapSeatedDumbellFlyePress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.SeatedDumbellFlyePress());
    }

    void TapInclineDumbellPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.InclineDumbellPress());
    }

    void TapCableFlye(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.CableFlye());
    }

    void TapStandingDumbelFlye(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.StandingDumbelFlye());
    }

}