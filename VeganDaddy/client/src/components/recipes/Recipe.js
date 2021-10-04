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
            <div>
                <div class="recipe-card">

                    <aside>

                        {/* <img src="https://s3-us-west-2.amazonaws.com/s.cdpn.io/203277/oatmeal.jpg" alt="Chai Oatmeal" /> */}


                    </aside>

                    <article>

                        <h2>{recipe.title}</h2>

                        <ul>
                            <li><span class="icon icon-users"></span><span>1</span></li>
                            <li><span class="icon icon-clock"></span><span>15 min</span></li>
                            <li><span class="icon icon-level"></span><span>Beginner level</span></li>
                            <li><span class="icon icon-calories"></span><span>248</span></li>
                        </ul>

                        <p>{recipe.description}</p>

                        {/* <p class="ingredients"><span>Ingredients:&nbsp;</span>Milk, salt, coriander, cardamom, cinnamon, turmeric, honey, vanilla extract, regular oats, oat bran.</p> */}

                    </article>

                </div>
                {/* <Card className="recipe_card" >
                    <CardBody>

                        <p><b>Title: </b></p>
                        <p><b>Description: </b></p>
                        <p><b>Instructions: </b>{recipe.instructions}</p>
                        <p><b>Date Posted: </b>{handleDate()}</p>
                        <p><b>Posted By: </b>{post.userProfile?.displayName}</p>
                    </CardBody>
                </Card > */}
            </div>



        </>
    );
};

export default Recipe;