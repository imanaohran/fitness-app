using Microsoft.Maui;
using System;

namespace Aptus
{
    public partial class BMIHeightPage : ContentPage
    {
        private double _height;
        public BMIHeightPage()
        {
            InitializeComponent();
        }

        private void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            _height = e.NewValue;
            HeightLabel.Text = string.Format("{0:F0} cm", _height);
            NextButton.IsEnabled = true;
        }

        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            var weightPage = new BMIWeightPage(_height);
            await Navigation.PushAsync(weightPage);
        }
        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
