import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './DetailPage.module.css';

import Navbar from '../../components/Navbar/Navbar';
import Button from '../../components/Button/Button';
import Carousel from '../../components/Carousel/Carousel';


const detailPage = () => {
    return (
        <div className>
            <Navbar />
            <div className={`container ${classes.content}`}>
                <div className="row">
                    <div className="col-sm">
                        <Carousel />
                    </div>
                </div>
            </div>
            <div className="col-sm">
                <h1>Product Title</h1>
                <h3>description</h3>
                <p>price</p>
                <Button btnType="addToCart">Add to cart</Button>
            </div>
        </div>
    );
};

export default detailPage;