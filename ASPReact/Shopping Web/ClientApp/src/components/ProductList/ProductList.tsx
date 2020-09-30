import React, { Component } from 'react';
import axios from 'axios';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './ProductList.module.css';

import data from '../../assets/data/data';
import Navbar from '../Navbar/Navbar';
import Button from '../Button/Button';
import Card from '../Card/Card';

class ProductList extends Component {
    state = { products: data};
    //state = { products: [] }

    //componentDidMount() {
    //    axios.get("http://localhost:51260/api/products").then((response: { data: any; }) => {
    //        //console.log(response.data);  
    //        this.setState({
    //            products: response.data
    //        });
    //    });
    //} 

    render() {

        let products = this.state.products.map(product => {
            return (
                <Card product={product}/>
            );
        });

        return (           

            <div>
                <div className={classes.sticky}>
                    <Navbar />
                </div>
    
                <div className={classes.container}>
                    <h1 className={classes.order}>Order</h1>
    
                    <div className="row">
                        <div className={`col-sm-3 ${classes.dropDownMenu}`}>
                            <Button btnType="dropdown-item">PICK-UP</Button>
                            <Button btnType="dropdown-item">DELIVERY</Button>
                            <Button btnType="dropdown">CURBSIDE PICK-UP</Button>
                        </div>
    
                        <div className="col-sm-9 d-flex flex-wrap justify-content-center">  
                            {products}
                        </div>
                    </div>
                </div>
            </div>
        )
    };
};

export default ProductList;