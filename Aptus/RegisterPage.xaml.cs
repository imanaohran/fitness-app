using Aptus.Data;
using Aptus.Models;
using Microsoft.Maui.Controls;
using SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aptus
{
    public partial class RegisterPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        public RegisterPage()
        {
            InitializeComponent();

            _connection = new SQLiteAsyncConnection(Database.DatabasePath, Database.Flags);
            _connection.CreateTableAsync<User>();
            SignUpButton.Clicked += SignUpButton_Clicked;
        }

        private async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                var query = _connection.Table<User>().Where(u => u.Email == EmailEntry.Text);
                var user = await query.FirstOrDefaultAsync();
                if (user != null)
                {

                    await DisplayAlert("Error", "User with this email already exists!", "Ok");
                    return;
                }
                else
                {
                    var newUser = new User
                    {
                        Username = UsernameEntry.Text,
                        Email = EmailEntry.Text,
                        Password = PasswordEntry.Text
                    };

                    await _connection.InsertAsync(newUser);
                    await DisplayAlert("Success", "User successfully added to the database!", "Ok");
                }
                await Navigation.PushAsync(new LoginPage());
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
        private void OnBackButton6Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
   
}