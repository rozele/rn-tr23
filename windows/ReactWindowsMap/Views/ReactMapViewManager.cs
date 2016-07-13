using ReactNative.UIManager;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls.Maps;

namespace ReactWindowsMap.Views
{
    class ReactMapViewManager : ViewParentManager<MapControl>
    {
        public override string Name
        {
            get
            {
                return "WindowsMapView";
            }
        }

        public override void AddView(MapControl parent, DependencyObject child, int index)
        {
            parent.Children.Insert(index, child);
        }

        public override DependencyObject GetChildAt(MapControl parent, int index)
        {
            return parent.Children[index];
        }

        public override int GetChildCount(MapControl parent)
        {
            return parent.Children.Count;
        }

        public override void RemoveAllChildren(MapControl parent)
        {
            parent.Children.Clear();
        }

        public override void RemoveChildAt(MapControl parent, int index)
        {
            parent.Children.RemoveAt(index);
        }

        protected override MapControl CreateViewInstance(ThemedReactContext reactContext)
        {
            return new MapControl();
        }
    }
}
