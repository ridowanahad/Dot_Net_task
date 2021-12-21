import React, { Component, PropTypes } from 'react';
import mapValues from 'lodash/object/mapValues';

import styles from './RankWebsitesList.css';
import RankWebsitesListItem from './RankWebsitesListItem';

export default class RankWebsitesList extends Component {
  static propTypes = {
    websites: PropTypes.object.isRequired,
    actions: PropTypes.object.isRequired
  }

  render () {
    return (
      <ul className={styles.rankWebsitesList}>
        {
          mapValues(this.props.websites, (website) => {
            return (<RankWebsitesListItem
              {...this.props.actions} />);
          })
        }
      </ul>
    );
  }

}
