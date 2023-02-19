using Aptus.ViewModels;

namespace Aptus;

public partial class FemaleFrontPage : ContentPage
{
    public FemaleFrontPage()
    {
        InitializeComponent();
        this.BindingContext = new IntroScreenViewModel2();
    }
    private void OnNextButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FemaleMusclePage(), true);
    }
}