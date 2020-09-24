import React from 'react';
import {Link} from 'react-router-dom';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './Navbar.module.css';

import Navigationitems from '../NavigationItems/NavigationItems';

const navBar = () => {
    return ( 
        <div className={classes.navBar}>
            <Navigationitems />
	    </div>
    );
};

export default navBar;