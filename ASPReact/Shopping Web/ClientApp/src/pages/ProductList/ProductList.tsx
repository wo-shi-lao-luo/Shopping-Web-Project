<<<<<<< HEAD
import React, { useState } from 'react';
=======
import React, { Component } from 'react';
import axios from 'axios';
>>>>>>> master

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './ProductList.module.css';

import data from '../../assets/data/data.json';
import Navbar from '../../components/Navbar/Navbar';
import Button from '../../components/Button/Button';
import Card from '../../components/Card/Card';

<<<<<<< HEAD
function productList () {
=======
class ProductList extends Component {
    //state = { products: data};
    state = { products: [] }

    componentDidMount() {
        axios.get("https://localhost:44344/api/products").then((response: { data: any; }) => {
            console.log("Product List:");
            console.log(response.data);  
            this.setState({
                products: response.data
            });
        });
    } 
    //componentDidMount() {
    //    fetch('https://localhost:44344/api/products')
    //        .then((response) => response.json())
    //        .then(productsList => {
    //            this.setState({ products: productsList });
    //            console.log("Product List");
    //            console.log(productsList);
    //        });
    //}
>>>>>>> master

    //const [products, setProducts] = useState(data);


    //let products = this.state.products.map(product => {
    //    return (
    //        <Card product={product} />
    //    );
    //});

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
                        {/*{products} */}
                    </div> 
                </div>
            </div>
        </div>
    )
};

export default productList;