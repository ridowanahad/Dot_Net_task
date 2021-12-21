import React, { Component, PropTypes } from 'react';
import styles from './RankWebsitesApp.css';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';

import * as actions from '../actions/actions';
import { RankWebsitesList} from '../components';

@connect(state => ({
  rankwebsitelist: state.rankwebsitelist
}))
export default class RankWebsitesApp extends Component {

  static propTypes = {
  //  websitesById: PropTypes.object.isRequired,
    dispatch: PropTypes.func.isRequired
  }

  render () {
    //const { rankwebsitelist: { websitesById }, dispatch } = this.props;
    const actions = bindActionCreators(actions, dispatch);

    return (
      <div className={styles.rankWebsitesApp}>
        <h1>Top 5 Websites of the day</h1>
      //  <RankWebsitesList websites={websitesById} actions={actions} />
      </div>
    );
  }
}
