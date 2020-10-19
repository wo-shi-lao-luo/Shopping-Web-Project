import React, { createContext, useReducer, useContext } from 'react';
import {
    SET_CURRENT_PRODUCTS,
    ADD_TO_CART,
    REMOVE_FROM_CART,
    UPDATE_CART
} from './actions';

//const StoreContext = createContext(defaultValue);
//const { Provider } = StoreContext;

//const reducer = (state, action) => {
//   switch (action.type) {
//       case SET_CURRENT_PRODUCTS:
//           return {
//               ...state,
//               currentProduct: action.product
//           }
//       case ADD_TO_CART:
//           return {
//               ...state,
               
//           }
//   }
//}