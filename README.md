# Request Response Models

The propuse of this repository is to create a sample of the models separantion used by the view in two types.

    * Request models: models that are receive by the controller when the user do some action at the view
    * Reponse models: models that are created by the controller and are send to view to show some data

This kind of models separation allow developers to not creating models with two kinf of constructors:

    1. Without parameters to be called by framework
    2. With services that get the data to be show at the view

If you have the two types of constructors in the same model, you need "complete" the view models when the framework calls the constructor without parameters.