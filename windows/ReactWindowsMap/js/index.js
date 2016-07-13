const React = require('react');
const requireNativeComponent = require('requireNativeComponent');
const View = require('View');

const LocationPropType = React.PropTypes.shape({
    lat: React.PropTypes.number.isRequired,
    lon: React.PropTypes.number.isRequired,
    alt: React.PropTypes.number,
});

class MapViewWindows extends React.Component {
    static propTypes = {
        ...View.propTypes,
        center: LocationPropType,
    }

    render() {
        return (
            <WindowsMapView
                style={this.props.style}
                center={this.props.center}>
                {this.props.children}
            </WindowsMapView>
        );
    }
}

const WindowsMapView = requireNativeComponent('WindowsMapView', MapViewWindows);

module.exports = {
    MapViewWindows,
};