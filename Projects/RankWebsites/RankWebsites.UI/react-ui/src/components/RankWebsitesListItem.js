import React, { Component, PropTypes } from 'react';
import classnames from 'classnames';
import styles from './RankWebsitesListItem.css';

export default class RankWebsitesListItem extends Component {
  static propTypes = {
    id: PropTypes.number.isRequired,
    name: PropTypes.string.isRequired
  }

  render () {
    return (
      <li className={styles.rankWebsitesListItem}>
      </li>
    );
  }

}
