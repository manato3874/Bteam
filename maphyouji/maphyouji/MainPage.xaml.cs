using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace maphyouji
{
    public partial class MainPage : ContentPage
    {


        public MainPage(){
            InitializeComponent();

            var initialPosition = new Location(37.3994, 140.3847); 
            map.MoveToRegion(MapSpan.FromCenterAndRadius(initialPosition, Distance.FromMiles(0.1)));

            map.MapClicked += (s, e) =>
            {
                var clickedPosition = e.Location;
                var initialPosition = new Location(clickedPosition.Latitude, clickedPosition.Longitude); 
                map.MoveToRegion(MapSpan.FromCenterAndRadius(initialPosition, Distance.FromMiles(0.1)));
            };
        }


    }
}
