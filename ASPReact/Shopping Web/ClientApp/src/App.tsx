import * as React from 'react';
import { Switch, Route } from 'react-router';

import HeroImage from './components/HeroImage/HeroImage';
import ProductList from "./components/ProductList/ProductList";
import DetailPage from "./components/DetailPage/DetailPage";
import Cart from "./components/Cart/Cart";

export default () => (
    <React.Fragment>
        <Switch>
            <Route exact path="/" component={HeroImage} />
            <Route path="/productlist" component={ProductList} />
            <Route path="/details" component={DetailPage} />
            <Route path="/cart" component={Cart} />
        </Switch>
    </React.Fragment>
);
