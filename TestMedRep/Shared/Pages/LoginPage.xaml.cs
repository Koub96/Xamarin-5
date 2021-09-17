using Xamarin.Forms;

namespace test.universal
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage ()
		{
            InitializeComponent();

            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Application.Current.MainPage.DisplayAlert("Button1", "Button2", "Button3", "Button4");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
