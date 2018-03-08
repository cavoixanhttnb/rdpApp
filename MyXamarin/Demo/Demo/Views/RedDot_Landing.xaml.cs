using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RedDot_Landing : ContentPage
	{
		public RedDot_Landing ()
		{
			InitializeComponent ();
        }

        private void ForResidential_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RedDot_Register());
        }
        private void ForBusiness_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RedDot_Landing());
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Login());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new RedDot_Register());
        }
    }
}