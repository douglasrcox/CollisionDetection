## The "Sims" Collision Detection Coding Example

This was a coding example completed for a job interview process, which I posted up here for others to take a look at.  It doesn't work, but someone can go ahead and implement the necessary changes to do so.  It's very simple and uses the following technologies:

1. Visual Studio 2017 Enterprise
2. C#
3. Command console project
4. .Net Core 2

### Coding Sample Requirements
------------------------------ 

All Sim characters are loaded with the same copy of your software. Imagine two of these sims are positioned somewhere on a line that extends to infinity in both directions, left and right. 
 
Using the below interface, write a C# method called "Collide" that ensures that the two sims will collide at some point in the future. Remember, the code that you write will be deployed to each Sim. You cannot write code that will be deployed to one and not the other. The method should have no parameters. You do not need to implement the ISim interface.

``` C#
public interface ISim
{
                void MoveLeft(); // Moves the sim character one unit on the line to the left
                void MoveRight(); // Moves the sim character one unit on the line to the right
                void Relax(); // Commands the sim character to not do anything
                void MarkPosition(); // Puts a mark on the line at the current position of the sim character
                bool IsCurrentPositionMarked(); // Inspects the current position of the sim character for a mark and returns true if one is found, false if one is not found.
};

```
