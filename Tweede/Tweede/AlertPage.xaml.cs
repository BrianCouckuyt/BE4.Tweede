using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tweede
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertPage : ContentPage
	{
		public AlertPage ()
		{
			InitializeComponent ();
		}


        private async void btnPopupHello_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert!", "Let op als je er Android", "Ok!");
        }

        private async void btnActionSheet_Clicked(object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: What to do?", "Cancel", null, "Show me the time", "Tell a joke", "Wait 3 seconds");
            if (action == "Show me the time") await DisplayAlert("Time", $"It's now {DateTime.Now.ToString("HH:mm")},Almost beer-o-clock!", "OK");
            else if (action == "Tell a joke") await DisplayAlert("Joke", $"Why is six afraid of seven?{Environment.NewLine}Because seven ate nine.", "LOL", "I don't get it");
            else if (action == "Wait 3 seconds") { await Task.Delay(3000);
            await DisplayAlert("Wait 3 seconds", "The wait is over.", "Ok"); } }


        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Go back?", "Do you want to go back?", "Yes", "No"))
            {
                await Navigation.PopAsync(true);
            }
        }
    }
}