import React from "react";
import { Switch, Route, Redirect } from "react-router-dom";
import Login from "./Login";
import Register from "./Register";

export default function ApplicationViews({ isLoggedIn }) {
    return (
        <main className="main" >
            <Switch>
                <Route path="/" exact>
                    {isLoggedIn ? "Hello" : <Redirect to="/login" />}

                </Route>

                <Route path="/login">
                    <Login />
                </Route>

                <Route path="/register">
                    <Register />
                </Route>
            </Switch>
        </main>
    );
};