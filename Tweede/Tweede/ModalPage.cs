using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Tweede
{
	public class ModalPage : ContentPage
	{
        public string NameEntered { get; set; }
        private Entry txtName = new Entry();

		public ModalPage ()
		{
            Button btnClose = new Button { Text = "Submit" };
            btnClose.Clicked += btnClose_Clicked;

			StackLayout layout = new StackLayout {
                HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = {
					new Label { Text = "Enter your name:" },
                    txtName,
                    btnClose
				}
			};
            Content = layout;
		}

        private async void btnClose_Clicked(object sender, EventArgs e)
        {
            NameEntered = txtName.Text;
            await Navigation.PopModalAsync(true);
        }

        protected override bool OnBackButtonPressed()
        {
            return true; //don't allow users to press the back button while this window is open
        }
    }
}