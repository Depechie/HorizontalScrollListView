using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using HorizontalScrollListView.Models;

namespace HorizontalScrollListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;

            List<House> houses = new List<House>();

            houses.Add(new House() { ID = 1, Image = "Assets/House01.png" });
            houses.Add(new House() { ID = 2, Image = "Assets/House02.png" });
            houses.Add(new House() { ID = 3, Image = "Assets/House03.png" });
            houses.Add(new House() { ID = 4, Image = "Assets/House04.png" });
            houses.Add(new House() { ID = 5, Image = "Assets/House05.png" });
            houses.Add(new House() { ID = 6, Image = "Assets/House06.png" });
            houses.Add(new House() { ID = 7, Image = "Assets/House07.png" });
            houses.Add(new House() { ID = 8, Image = "Assets/House08.png" });
            houses.Add(new House() { ID = 9, Image = "Assets/House09.png" });

            this.HorizontalListViewSelectable.ItemsSource = this.HorizontalListViewNonSelectable.ItemsSource = houses;            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}
