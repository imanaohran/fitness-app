using Aptus.ViewModels;

namespace Aptus;

public partial class MaleFrontPage : ContentPage
{
    public MaleFrontPage()
    {
        InitializeComponent();
        this.BindingContext = new IntroScreenViewModel();
    }
    private void OnNextButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TabbedPage(), true);
    }
}