namespace Aptus;

public partial class GoalsPage : ContentPage
{
	public GoalsPage()
	{
		InitializeComponent();

    }
    private void OnNextButton4Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GenderPage());
    }
    private void OnBackButton4Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private void OnGainStrenghtButtonClicked(object sender, EventArgs e)
    {

            gainStrengthButton.BorderColor = Color.FromArgb("#364B51");
            gainStrengthButton.BorderWidth = 2;
            gainMuscleButton.BorderColor = Color.FromArgb("#FFFFFF");
            loseWeightButton.BorderColor = Color.FromArgb("#FFFFFF");
    }
    private void OnGainMuscleButtonClicked(object sender, EventArgs e)
    {

        gainMuscleButton.BorderColor = Color.FromArgb("#364B51");
        gainMuscleButton.BorderWidth= 2;
        gainStrengthButton.BorderColor = Color.FromArgb("#FFFFFF");
        loseWeightButton.BorderColor = Color.FromArgb("#FFFFFF");

    }
    private void OnLoseFatButtonClicked(object sender, EventArgs e)
    {

        loseWeightButton.BorderColor = Color.FromArgb("#364B51");
        loseWeightButton.BorderWidth = 2;
        gainStrengthButton.BorderColor = Color.FromArgb("#FFFFFF");
        gainMuscleButton.BorderColor = Color.FromArgb("#FFFFFF");

    }

}       