using Aptus.Models;
using SQLite;
using Aptus;
using System;
using System.Linq;
using System.Threading.Tasks;
using Aptus.Data;

namespace Aptus
{
    public partial class LoginPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        public LoginPage()
        {
            InitializeComponent();
            _connection = new SQLiteAsyncConnection(Data.Database.DatabasePath, Data.Database.Flags);
            LoginButton.Clicked += LoginButton_Clicked;
        }
        private async void TapGestureRecognizer_Tapped_For_SignUp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var query = _connection.Table<User>().Where(u => u.Email == EmailEntry.Text);
                var user = await query.FirstOrDefaultAsync();
                if (user != null && user.Password == PasswordEntry.Text)
                {
                    UserCred.Email = user.Email;
                    UserSession.Username = user.Email;
                    await Navigation.PushAsync(new BMIHeightPage());
                }
                else
                {
                    await DisplayAlert("Error", "Invalid email or password", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
