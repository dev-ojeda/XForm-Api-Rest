namespace XForm_Api_Rest.Pages
{
    using System;
    using System.Linq;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using XForm_Api_Rest.Model;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            var user = new UsuarioModel()
            {
                Usuario = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            // Sign up logic goes here

            var signUpSucceeded = AreDetailsValid(user);
            if (signUpSucceeded)
            {
                var rootPage = Navigation.NavigationStack.FirstOrDefault();
                if (rootPage != null)
                {
                    App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
            }
            else
            {
               await  DisplayAlert("Sign Up", "Sign up failed", "OK");
            }
        }

        bool AreDetailsValid(UsuarioModel user)
        {
            return (!string.IsNullOrWhiteSpace(user.Usuario) && !string.IsNullOrWhiteSpace(user.Password));
        }
    }
}