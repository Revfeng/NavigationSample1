using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigateTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack.Where(p => p is Page2).FirstOrDefault());
            await Navigation.PopAsync();
        }

    }
}