namespace Aptus.Exercises;

public partial class ShouldersPage : ContentPage
{
	public ShouldersPage()
	{
		InitializeComponent();
	}
    void TapBentOverRaises(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.BentOverRaises());
    }
    void TapChestSupportedLateralRaises(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.ChestSupportedLateralRaises());
    }
    void TapFacePulls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.FacePulls());
    }
    void TapLateralRaises(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.LateralRaises());
    }
    void TapOneArmShoulderPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.OneArmShoulderPress());
    }
    void TapShoulderPress(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Explanation.ShoulderPress());
    }

}