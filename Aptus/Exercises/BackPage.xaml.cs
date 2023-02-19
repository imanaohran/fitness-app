namespace Aptus.Exercises;

public partial class BackPage : ContentPage
{
	public BackPage()
	{
		InitializeComponent();
	}
    void TapPullUp(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.PullUp());
    }

    void TapCableRow(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.CableRow());
    }

    void TapDeadlift(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.Deadlift());
    }

    void TapDumbellPullover(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.DumbellPullover());
    }

    void TapDumbellShrugs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.DumbellShrugs());
    }

    void TapShrugs(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.Shrugs());
    }

    void TapStandingCableRow(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.StandingCableRow());
    }
}