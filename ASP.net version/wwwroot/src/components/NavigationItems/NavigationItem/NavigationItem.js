import React from 'react';
import { NavLink } from 'react-router-dom';

import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './NavigationItem.module.css';

const navigationItem = (props) => (
    <li className={classes.nav}>
        <NavLink to={props.link} className={props.active ? classes.active : null}>
            {props.children}
        </NavLink>
    </li>
);

export default navigationItem;