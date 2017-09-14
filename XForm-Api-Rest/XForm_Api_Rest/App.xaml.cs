namespace XForm_Api_Rest
{
    using Xamarin.Forms;

    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public App()
        {
            //InitializeComponent();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new XForm_Api_Rest.Pages.LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new XForm_Api_Rest.Pages.MainPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
