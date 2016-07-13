using System;
using ReactNative.UIManager;
using Windows.UI.Xaml.Controls;
using ReactNative.UIManager.Annotations;
using Newtonsoft.Json.Linq;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

namespace ReactWindowsMap.Views
{
    class ReactMapItemManager : PanelViewParentManager<Canvas>
    {
        public override string Name
        {
            get
            {
                return "WindowsMapItem";
            }
        }

        [ReactProp("location")]
        public void SetLocation(Canvas view, JObject location)
        {
            var lat = location.Value<double>("lat");
            var lon = location.Value<double>("lon");
            var alt = location.Value<double>("alt");

            var position = new BasicGeoposition
            {
                Latitude = lat,
                Longitude = lon,
                Altitude = alt,
            };

            MapControl.SetLocation(view, new Geopoint(position));
        }

        protected override Canvas CreateViewInstance(ThemedReactContext reactContext)
        {
            return new Canvas();
        }
    }
}
