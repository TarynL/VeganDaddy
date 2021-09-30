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
                <Card >
                    <CardBody>

                        <p><b>Title: </b>{recipe.title}</p>
                        <p><b>Description: </b>{recipe.description}</p>
                        <p><b>Instructions: </b>{recipe.instructions}</p>
                        <p><b>Date Posted: </b>{handleDate()}</p>
                        {/* <p><b>Posted By: </b>{post.userProfile?.displayName}</p> */}
                    </CardBody>
                </Card >
            </div>



        </>
    );
};

export default Recipe;