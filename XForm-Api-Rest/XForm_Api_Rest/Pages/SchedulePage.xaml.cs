namespace XForm_Api_Rest.Pages
{
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
        }

        async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpcomingAppointmentsPage());
        }
    }
}