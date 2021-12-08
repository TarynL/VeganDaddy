import React from "react";

import { Card, CardBody } from "reactstrap";
import { Link } from 'react-router-dom';


const Recipe = ({ recipe }) => {


    const handleDate = () => {
        let date = new Date(recipe.postedDate).toLocaleDateString();
        return date;
    };

    return (
        <>

            <div id="container">

                <div class="recipe-details">

                    <h1>{recipe.title}</h1>
                    <span class="hint-star star">
                        <i class="fa fa-star" aria-hidden="true"></i>
                        <i class="fa fa-star" aria-hidden="true"></i>
                        <i class="fa fa-star" aria-hidden="true"></i>
                        <i class="fa fa-star" aria-hidden="true"></i>
                        <i class="fa fa-star-o" aria-hidden="true"></i>
                    </span>

                    <div class="information">{recipe.description}
                        <p>
                            <span><i class="fa fa-users" aria-hidden="true"> 1</i></span>
                            <span><i class="fa fa-clock-o" aria-hidden="true"> 15 min</i></span></p>
                    </div>

                    <div class="instructions">
                        <p>{recipe.instructions}</p>
                    </div>



                </div>

                <div class="recipe-image">

                    <img src={recipe.imageUrl} />

                </div>

            </div>



        </>
    );
};

export default Recipe;