import React, { Component } from 'react';
import { Header, Icon, List } from 'semantic-ui-react';

import './App.css';
import axios from 'axios';

class App extends Component {
    state = {
        weatherforecast: [],
    };

    componentDidMount() {
        axios.get('http://localhost:5000/weatherforecast').then((response) => {
            this.setState({
                weatherforecast: response.data,
            });
        });
    }
    render() {
        return (
            <div>
                <Header as="h2">
                    <Icon name="plug" />
                    <Header.Content>Uptime Guarantee</Header.Content>
                </Header>
                <List>
                {this.state.weatherforecast.map((weather: any) => (
                        <List.Item key={weather.id}>{weather.summary}</List.Item>
                    ))}
                    
                    
                </List>
                
            </div>
        );
    }
}

export default App;
