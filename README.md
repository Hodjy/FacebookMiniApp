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
    
### Class Diagram:
![image](https://user-images.githubusercontent.com/62711261/109400185-e36ed180-794f-11eb-8900-57c6f3a30817.png)

Will seperate the subsystem from the front-end classes, and will simplify the commands while tailoring them for spesific front-end usage.       

## Proxy+Adapter:   
    
### Class Diagram:
![image](https://user-images.githubusercontent.com/62711261/109400211-0dc08f00-7950-11eb-84cb-228c3fbdfece.png)


The "User" class is as a Legacy Component, therefore we used an Adapter Design Pattern for the Proxy Design Pattern.        
With Proxy Design Pattern we added extra features to the class "User" and turned it into a spesific class "LoggedInUser".         
In addition, we can add more features in the future with ease.      
    

### Sequence Diagram:
![image](https://user-images.githubusercontent.com/62711261/109401249-495e5780-7956-11eb-8105-c95eee73c73a.png)

(click to view in more detail)    
Showcase the sequence of logging in. The process include using the Proxy class "LoggedInUser".

## Visitor:    
    
### Class Diagram:
![image](https://user-images.githubusercontent.com/62711261/109401292-77dc3280-7956-11eb-9592-be0190026a6e.png)

In order to implement "Dark Mode" for our UI, we used the Visitor Design Pattern.       
We created a Proxy for each Legacy Component that we desired a dark mode functionability for.       
With the Visitor Design Pattern we can add Dark Mode functionability with ease, and reuse its logic.        

### Sequence Diagram:
![image](https://user-images.githubusercontent.com/62711261/109401641-7b70b900-7958-11eb-8c28-35ba4d687604.png)

(click to view in more detail)      
Showcase the sequence of pressing the "Toggle Dark Mode" button.        

## Command:
        
### Class Diagram:
![image](https://user-images.githubusercontent.com/62711261/109401745-110c4880-7959-11eb-921d-5c17f0b10cd5.png)

With the Command Design Pattern we created a "drop down menu" that we can swap between filter types with ease.       
Instead of using naive methods such as "switch case" for user selection, and to make adding more filter types simpler and easier, we used the Command Design Pattern.
