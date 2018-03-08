using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RedDot_Register : CarouselPage
    {
        public RedDot_Register()
        {
            InitializeComponent();
            
            picSalutationBasic.Items.Add("Please Select");
            picSalutationBasic.Items.Add("Mr.");
            picSalutationBasic.Items.Add("Ms.");
            picSalutationBasic.Items.Add("Mrs.");
        }

        private void picSalutationBasic_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var name = picSalutationBasic.Items[picSalutationBasic.SelectedIndex];
        }

        /// <summary>
        /// Go register clicked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Event</param>
        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
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
    }
}