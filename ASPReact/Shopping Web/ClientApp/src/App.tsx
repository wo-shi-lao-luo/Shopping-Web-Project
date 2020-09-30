import * as React from 'react';
import { Switch, Route } from 'react-router';

import HeroImage from './pages/HeroImage/HeroImage';
import ProductList from "./pages/ProductList/ProductList";
import DetailPage from "./pages/DetailPage/DetailPage";
import Cart from './pages/Cart/Cart';

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
