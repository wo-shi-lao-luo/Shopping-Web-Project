import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './DetailPage.module.css';

import Navbar from '../../components/Navbar/Navbar';
import Button from '../../components/Button/Button';
import Carousel from '../../components/Carousel/Carousel';

const detailPage = (props:any) => {
    return (
        <div>
            <Navbar />
            <div className={`container ${classes.outter}`}>
                <div className={`row ${classes.content}`}>
                    <div className="col-xs-12 col-md-6">
                        <Carousel />
                    </div>
                    <div className={`col-xs-12 col-md-6 ${classes.info}`}>
                        <h1 className={classes.title}>Product Title</h1>
                        <h3 className={classes.description}>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</h3>
                        <p className={classes.price}>$30</p>
                        <Button btnType="addToCart">Add to cart</Button>
                    </div>
                    </div>
            </div>
        </div>
    );
};

export default detailPage;