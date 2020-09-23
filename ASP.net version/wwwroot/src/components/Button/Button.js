import React from 'react';

import '../../../node_modules/bootstrap/dist/css/bootstrap.min.css';
import classes from './Button.module.css';

const button = (props) => {
    return (
        <button
            onClick={props.clicked} 
            className={[classes[props.btnType], classes.button].join(' ')}>
            <span>{props.children}</span>
        </button>
    );
};

export default button;