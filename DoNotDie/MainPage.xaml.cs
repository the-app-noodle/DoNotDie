using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DoNotDie
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        static string bomb = new Random().Next(1, 4).ToString();
        int pts = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void ButtonClicked(Object sender, EventArgs e) {

            Button button = sender as Button;

            // This is a game over scenario
            if (button.Text == bomb)
            {
                await DisplayAlert("GAME OVER", "Sorry, you have clicked on the bomb and died \nPoints: " + pts, "Retry");
                bomb = new Random().Next(1, 4).ToString();
                pts = 0;
            }

            // This is for picking a button that is not a bomb
            else {
                pts += 1;
                bomb = new Random().Next(1, 4).ToString();
            }
        
        }
    }
}
