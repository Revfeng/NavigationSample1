using NavigateTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigateTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        private readonly Page2ViewModel page2ViewModel;

		public Page2 ()
		{
            page2ViewModel = new Page2ViewModel();
			InitializeComponent ();
            BindingContext = page2ViewModel;
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Debug.WriteLine("Before Push to Page 3");

            //Debug.WriteLine("Navigation Stack");
            //foreach (var item in Navigation.NavigationStack)
            //{
            //    Debug.WriteLine(item.GetType().Name);
            //}

            //Debug.WriteLine("Modal Stack");
            //foreach (var item in Navigation.ModalStack)
            //{
            //    Debug.WriteLine(item.GetType().Name);
            //}

            await Navigation.PushAsync(new Page3());

            //Debug.WriteLine("After Push to Page 3");

            //Debug.WriteLine("Navigation Stack");
            //foreach (var item in Navigation.NavigationStack)
            //{
            //    Debug.WriteLine(item.GetType().Name);
            //}

            //Debug.WriteLine("Modal Stack");
            //foreach (var item in Navigation.ModalStack)
            //{
            //    Debug.WriteLine(item.GetType().Name);
            //}
        }
    }
}