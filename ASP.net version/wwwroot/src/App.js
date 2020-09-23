import React from 'react';
import { Switch, Route, withRouter, Redirect } from 'react-router-dom';
import { connect } from 'react-redux';

import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

import HeroImage from './containers/HeroImage/HeroImage';
import ProductList from "./containers/ProductList/ProductList";
import DetailPage from "./containers/DetailPage/DetailPage.module";
import Cart from "./containers/Cart/Cart";

function App() {
  return (
    <React.Fragment>
      <Switch>
        <Route exact path="/" component={HeroImage} />
        <Route path="/productlist" component={ProductList} />
        <Route path="/details" component={DetailPage} />
        <Route path="/cart" component={Cart} />
      </Switch>
    </React.Fragment>
  );
}

export default App;