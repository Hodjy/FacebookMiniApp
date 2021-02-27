# FacebookMiniApp
A Facebook app that showcases multiple uses of Design Patterns. Written in a C# college course. Written in C# and using Windows Forms.          
This project is ment to show our understanding of Design Patterns, Class Diagrams, Sequence Diagrams, and Simple Threading.      

The app uses Facebook's API with a premade wrapper that was given to us. The wrapper is old and outdated, thus some commands wont work due to new access limitations.

In this readme, we will show some of the Design Patterns we used in the project.      

Design Pattern used:    

* Facade
* Adapter
* Proxy
* Strategy
* Command
* Visitor

## Facade:

![image](https://user-images.githubusercontent.com/62711261/109400185-e36ed180-794f-11eb-8900-57c6f3a30817.png)

Will seperate the subsystem from the front-end classes, and will simplify the commands while tailoring them for spesific front-end usage.

## Proxy+Adapter:

![image](https://user-images.githubusercontent.com/62711261/109400211-0dc08f00-7950-11eb-84cb-228c3fbdfece.png)


"User" was counted as a "Legacy Component", therefore we used an "Adapter" for the Proxy design pattern. 
With Proxy design pattern we added extra features to the class "User" and turned it into a spesific class "LoggedInUser".     
In addition, we can add more features in the future with ease.
