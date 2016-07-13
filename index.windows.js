/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 * @flow
 */

import React, { Component } from 'react';
import {
  AppRegistry,
  StyleSheet,
  Text,
  TouchableWithoutFeedback,
  View
} from 'react-native';
import {
  MapViewWindows,
  MapItemWindows,
} from 'react-native-windows-map';

class myapp extends Component {
  constructor(props) {
    super(props);
    this.state = {
      pressed: 0
    };
  }

  render() {
    return (
      <View style={styles.container}>
        <MapViewWindows
          style={styles.map}
          center={{lat: 47.6, lon: -122.33}}>
          <MapItemWindows
            location={{lat: 47.6, lon: -122.33}}>
            <TouchableWithoutFeedback
              onPress={this.onPress.bind(this)}>
              <View style={styles.icon} />
            </TouchableWithoutFeedback>
          </MapItemWindows>
        </MapViewWindows>
        <Text>
          Pressed {this.state.pressed} times!
        </Text>
      </View>
    );
  }

  onPress() {
    this.setState({pressed: this.state.pressed + 1});
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  welcome: {
    fontSize: 20,
    textAlign: 'center',
    margin: 10,
  },
  instructions: {
    textAlign: 'center',
    color: '#333333',
    marginBottom: 5,
  },
  map: {
    width: 500,
    height: 500,
  },
  icon: {
    width: 10,
    height: 10,
    borderRadius: 5,
    backgroundColor: 'blue'
  }
});

AppRegistry.registerComponent('myapp', () => myapp);