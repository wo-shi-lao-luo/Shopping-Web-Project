import React from 'react';
import { NavLink } from 'react-router-dom';

import '../../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './NavigationItem.module.css';

const navigationItem = (props:any) => (
    <li className={classes.nav}>
        <NavLink to={props.link}>
            {props.children}
        </NavLink>
    </li>
);

export default navigationItem;