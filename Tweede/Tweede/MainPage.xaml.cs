using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tweede
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Application.Current.ModalPopped += modalPopped;

            var messageService = DependencyService.Get<IMessageService>();

            lblWelcome.Text = "Piep, " + messageService.GetWelcomeMessage();
        }

        private async void modalPopped(object sender, ModalPoppedEventArgs e)
        {
            if(e.Modal is ModalPage)
                await DisplayAlert("Modal Result", $"You entered {(e.Modal as ModalPage).NameEntered}", "I know!");
        }

        private async void btnActionSheet_Clicked(object sender, System.EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: What to do?", "Cancel", null, "Show me the time", "Tell a joke", "Wait 3 seconds");
            if (action == "Show me the time") await DisplayAlert("Time", $"It's now {DateTime.Now.ToString("HH:mm")},Almost beer-o-clock!", "OK");
            else if (action == "Tell a joke") await DisplayAlert("Joke", $"Why is six afraid of seven?{Environment.NewLine}Because seven ate nine.", "LOL", "I don't get it");
            else if (action == "Wait 3 seconds") { await Task.Delay(3000); await DisplayAlert("Wait 3 seconds", "The wait is over.", "Ok"); } }


        private async void btnAlertPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AlertPage());
        }

        private async void btnShowModal_Clicked(object sender, EventArgs e)
        {
            var modalPage = new ModalPage();
            await Navigation.PushModalAsync(modalPage, true);
        }

        private async void btnRandomNumber_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RandomNumberPage(), true);
        }
    }
}
