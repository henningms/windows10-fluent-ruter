using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestRuterFluent
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowTripsPage : Page
    {
        public ShowTripsPage()
        {
            this.InitializeComponent();

            TripListView.ItemsSource = new List<string> {"Stortinget 1 min", "Natonal 2 min", "Scooby doo 5 min"};
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var place = e.Parameter as string;

            PlaceTextBox.Text = place;

            var placeAnimation = ConnectedAnimationService.GetForCurrentView().GetAnimation("textbox");

            placeAnimation?.TryStart(PlaceTextBox, new []{TripListView});
        }
    }
}
