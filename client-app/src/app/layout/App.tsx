import React, { useEffect, Fragment, useContext } from 'react';
import { Container } from 'semantic-ui-react';
import ActivityDashboard  from '../../features/activities/dashboard/ActivityDashboard';
import { observer} from 'mobx-react-lite';

import  Navbar  from '../../features/nav/Navbar';
import {LoadingComponent} from './LoadingComponent';
import ActivityStore from '../stores/activityStore';

const App = () => {
    const activityStore = useContext(ActivityStore);

    useEffect(() => {
        activityStore.loadActivities();
    }, [activityStore]);

    if(activityStore.loadingInitial) return <LoadingComponent content='loading'/>

    return (
        <Fragment>
            <Navbar />
            <Container style={{ marginTop: '7em' }}>
                <ActivityDashboard/>
            </Container>
        </Fragment>
    );
};

export default observer(App);
