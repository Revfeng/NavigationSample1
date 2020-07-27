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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			Debug.WriteLine("Before Push to Page 2");

            Debug.WriteLine("Navigation Stack");
            foreach (var item in Navigation.NavigationStack)
            {
                Debug.WriteLine(item.GetType().Name);
            }

            Debug.WriteLine("Modal Stack");
            foreach (var item in Navigation.ModalStack)
            {
                Debug.WriteLine(item.GetType().Name);
            }

            await Navigation.PushAsync(new Page2());

            Debug.WriteLine("After Push to Page 2");

            Debug.WriteLine("Navigation Stack");
            foreach (var item in Navigation.NavigationStack)
            {
                Debug.WriteLine(item.GetType().Name);
            }

            Debug.WriteLine("Modal Stack");
            foreach (var item in Navigation.ModalStack)
            {
                Debug.WriteLine(item.GetType().Name);
            }
        }

        //private async void Button_Clicked2(object sender, EventArgs e)
        //{
        //    Debug.WriteLine("Before Push to Page 2");

        //    Debug.WriteLine("Navigation Stack");
        //    foreach (var item in Navigation.NavigationStack)
        //    {
        //        Debug.WriteLine(item.GetType().Name);
        //    }

        //    Debug.WriteLine("Modal Stack");
        //    foreach (var item in Navigation.ModalStack)
        //    {
        //        Debug.WriteLine(item.GetType().Name);
        //    }

        //    await Navigation.PushAsync(new Page3());         

        //    Debug.WriteLine("After Push to Page 2");

        //    Debug.WriteLine("Navigation Stack");
        //    foreach (var item in Navigation.NavigationStack)
        //    {
        //        Debug.WriteLine(item.GetType().Name);
        //    }

        //    Debug.WriteLine("Modal Stack");
        //    foreach (var item in Navigation.ModalStack)
        //    {
        //        Debug.WriteLine(item.GetType().Name);
        //    }
        //}
    }
}