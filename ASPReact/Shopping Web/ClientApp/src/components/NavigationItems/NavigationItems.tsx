import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './NavigationItems.module.css';

import NavigationItem from './NavigationItem/NavigationItem';

const navigationItems = () => (
    <div className={classes.navList}>
        <ul className={classes.nav}>
            <NavigationItem link="/">Home</NavigationItem>
            <NavigationItem link="/products">Order</NavigationItem>
            <NavigationItem link="/contact">Contact</NavigationItem>
        </ul>

        <ul className={`${classes.nav} ml-auto`}>
            <NavigationItem link="/location"><i className="fas fa-map-marker-alt"></i>Location</NavigationItem>
            <NavigationItem link="/login"><i className="fas fa-sign-in-alt"></i>Login</NavigationItem>
            <NavigationItem link="/search"><i className="fa fa-search"></i>Search</NavigationItem>
            <NavigationItem link="/cart"><i className="fas fa-shopping-cart"></i>My Cart</NavigationItem>
        </ul>
    </div>
    
);

export default navigationItems;