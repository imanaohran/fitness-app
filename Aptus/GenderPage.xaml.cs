namespace Aptus
{
    public partial class GenderPage : ContentPage
    {
        private bool _isMaleSelected = false;
        private bool _isFemaleSelected = false;

        public GenderPage()
        {
            InitializeComponent();
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (_isMaleSelected)
            {
                Navigation.PushAsync(new MaleFrontPage());
            }
            else if (_isFemaleSelected)
            {
                Navigation.PushAsync(new FemaleFrontPage());
            }
        }

        private void OnImage3Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnMaleButtonClicked(object sender, EventArgs e)
        {
            MaleButton.Source = "maleclicked.png";
            FemaleButton.Source = "femalepng.png";
            NextButton.IsEnabled = true;
            _isMaleSelected = true;
            _isFemaleSelected = false;
        }

        private void OnFemaleButtonClicked(object sender, EventArgs e)
        {
            MaleButton.Source = "malepng.png";
            FemaleButton.Source = "femaleclicked.png";
            NextButton.IsEnabled = true;
            _isFemaleSelected = true;
            _isMaleSelected = false;
        }
    }
}

