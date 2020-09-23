import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './DetailPage.module.css';

import Navbar from '../../components/Navbar/Navbar';
import Button from '../../components/Button/Button';
import img from '../../assets/img/1.jpg';

const detailPage = () => {
    return (
        <div className>
            <Navbar />
            <div className={`container ${classes.content}`}>
                <div className="row">
                    <div className="col-sm">
                        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                            <ol class="carousel-indicators">
                                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                            </ol>

                            <div class="carousel-inner">
                                <div class="carousel-item active">
                                    <img class="d-block" src={img} alt="First slide"></img>
                                </div>
                                <div class="carousel-item">
                                    <img class="d-block" src={img} alt="Second slide"></img>
                                </div>
                                <div class="carousel-item">
                                    <img class="d-block" src={img} alt="Third slide"></img>
                                </div>
                            </div>
                            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="sr-only">Previous</span>
                            </a>
                            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="sr-only">Next</span>
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