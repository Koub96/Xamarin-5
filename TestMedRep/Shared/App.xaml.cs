using System;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace test.universal
{
	public partial class App : Application
	{
        public App()
		{
            InitializeComponent();

            MainPage = new LoginPage();
        }

    }

}
