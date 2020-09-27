import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './Carousel.module.css';

import img from '../../assets/img/1.jpg';

const Carousel = () => {
    return (
        <div className={`mx-auto ${classes.content}`}>
            <div className="row">
                <div className="col-sm">
                    <div id="carouselExampleIndicators" className="carousel slide" data-ride="carousel">
                        

                        <div className={`carousel-inner ${classes.inner} mx-auto`}>
                            <div className={`carousel-item active`}>
                                <img className="d-block w-100" src={img} alt="First slide"></img>
                            </div>
                            <div className={`carousel-item`}>
                                <img className="d-block w-100" src={img} alt="Second slide"></img>
                            </div>
                            <div className={`carousel-item`}>
                                <img className="d-block w-100" src={img} alt="Third slide"></img>
                            </div>
                        </div>

                        <ol className={`carousel-indicators ${classes.indicator}`}>
                            <li data-target="#carouselExampleIndicators" data-slide-to="0" className="active"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                        </ol>
                    </div>
                </div>
            </div>
        </div>
      );
};

export default Carousel;