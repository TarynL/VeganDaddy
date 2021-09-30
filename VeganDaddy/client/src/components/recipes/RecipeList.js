import React, { useEffect, useState } from "react";
import { Container } from 'reactstrap';
import Recipe from "./Recipe";
import { getAllRecipes } from "../../modules/recipeManager";

const RecipeList = () => {
    const [recipes, setRecipes] = useState([]);



    const getRecipes = () => {
        getAllRecipes().then(r => setRecipes(r));
    };

    useEffect(() => {
        getRecipes();

    }, []);

    return (
        <>
            <Container className="recipelist ">
                <div className="row ">
                    {recipes.map((recipe) => (
                        <Recipe recipe={recipe} key={recipe.id} />
                    ))}
                </div>
            </Container>

        </>
    );

};

export default RecipeList;