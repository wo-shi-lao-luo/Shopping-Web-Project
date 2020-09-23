import React from 'react';
import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './HeroImage.module.css';

import Navbar from '../../components/Navbar/Navbar';
import Button from '../../components/Button/Button';

const heroImage = () => {
    return (
        <div className={classes.heroImage}>
            <div className={classes.freeShip}>
                <h3>FREE SHIPPING OVER $50. GET 10% OFF SITEWIDE.</h3>
            </div>

            <div className={classes.title}>
                <h1>C&J Bakery</h1>
            </div>

            <Navbar />

            <div className={`${classes.container} ${classes.abstract}`}>
                <div className="row">
                    <div className="col-sm">
                    <h2>Christmas Limited</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                    <Button>EXPLORE</Button>
                    </div>
                    <div className="col-sm"></div>
                    <div className="col-sm"></div>
                </div>
            </div>
        </div>
    );
};

export default heroImage;