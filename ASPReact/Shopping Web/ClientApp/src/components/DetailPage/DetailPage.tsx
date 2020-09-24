import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './DetailPage.module.css';

import Navbar from '../Navbar/Navbar';
import Button from '../Button/Button';
import img from '../../assets/img/1.jpg';

const detailPage = () => {
    return (
        <div className="">
            <Navbar />
            <div className={`container ${classes.content}`}>
                <div className="row">
                    <div className="col-sm">
                        <div id="carouselExampleIndicators" className="carousel slide" data-ride="carousel">
                            <ol className="carousel-indicators">
                                <li data-target="#carouselExampleIndicators" data-slide-to="0" className="active"></li>
                                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                            </ol>

                            <div className="carousel-inner">
                                <div className="carousel-item active">
                                    <img className="d-block" src={img} alt="First slide"></img>
                                </div>
                                <div className="carousel-item">
                                    <img className="d-block" src={img} alt="Second slide"></img>
                                </div>
                                <div className="carousel-item">
                                    <img className="d-block" src={img} alt="Third slide"></img>
                                </div>
                            </div>
                            <a className="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                                <span className="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span className="sr-only">Previous</span>
                            </a>
                            <a className="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                                <span className="carousel-control-next-icon" aria-hidden="true"></span>
                                <span className="sr-only">Next</span>
                            </a>
                        </div>
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