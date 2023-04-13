# Mod1 Week4 Assessment
This assessment has two parts - some questions about this week's lessons, and an exercise focused on our Testing lesson. Work on the Questions first, then move on to the Exercise!

## Setup

Fork this repository!

## Questions (12 Points Possible)
Edit this `README.md` file - answer the BLANK questions before moving on to the exercise.  Make sure to SAVE your changes to the README before moving on!

1. Review the class definition below:
    ```c#
    public class Chair
    {
        public int Height { get; }
        public bool HasBack { get; }

        public Chair(int height, bool hasBack)
        {
            Height = height;
            HasBack = hasBack;
        }
    }
    ```
    Which of the following is NOT a valid way to create an instance of Chair? And why does this option not work?  
    A. `var bench = new Chair(24, true);`  
    B. `Chair bench = new Chair(24, true);`  
    C. `var bench = new(24, true);`  
    D. `Chair bench = new(24, true);`  
    Answer: C is the only listed non-valid way to create a Chair object. The reason why is that when instantiating an object in C# using a class you have to either define the data type prior to the instantiation or with var if you then specify the data type after you type new. If you only use var and new without specifying the object's data type then it won't know what datatype the object is and cant infer what var will be. This leads to c being a non-valid way to make an instantiation of the class `Chair`. 
    
2. Imagine you are interviewing for your first job.  The interviewer asks "What can you tell me about OOP?".  Write your response below:
Answer: OPP stands for `Object Oriented Code`. Although it says 'code' in the name, I prefer to think of OOP as a programming pattern or structure that provides a way to organize and manage code. In OOP we create classes that can be instantiated to represent objects. These objects can have their own behaviors and properties. This allows the code to become more modular and easier to manage. 

3. What is Automated Testing?
Answer: Automated testing is the practice of writing tests, typically using a testing framework, with the goal of catching bugs or unexpected behavior in your software application. In C# we have used the Xunit framework to accomplish this, which enables us to create a separate subproject specifically for housing our Xunit tests. Allowing us to test various components of our application, including class constructors, methods, and properties. 

4. What are some benefits of creating tests for our projects?
Answer: We can create tests for our projects to generate test coverage. Test coverage is the concept that a certain amount of your code is being tested and deemed reliable since it's been tested. This ensures that your program will have fewer bugs since you will be able to test your classes and catch any unexpected behaviors. Testing can ensure the stability, reliability, and overall quality of our software, making it more robust and easier to maintain in the long run.

5. When you create a test project, you do not immediately have access to the class(es) in the project that you are testing.  What do you need to do in order to have access to those classes?
Answer: You first need to add a reference to your main program by right-clicking on the solution of your project and hitting `add Reference`. This will pull up a menu that will allow you to select a different project within your current solution connecting the two projects. 

6. Take a look at the class below.  Write out the **names** of each test you would write to verify that this class is working.
```c#
    public class Vehicle
    {
        public int NumberOfWheels { get; }
        public string Color { get; private set;  }
        public int MilesDriven { get; private set; }

        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
            MilesDriven = 0;
        }

        public string Sumary()
        {
            string summary = $"This {Color} vehicle has {NumberOfWheels} wheels, and has driven {MilesDriven} miles.";
            return summary;
        }

        public void Drive()
        {
            MilesDriven += 5;
        }

        public void Paint(string newColor)
        {
            Color = newColor;
        }
    }
```
  Answer: 
  Tests for classes and methods: 
  - Test_Vehicle_Constructor_Properties
	  - A test to check if all properties initialize correctly in the Vehicle constructor 
  - Test_String_Summary_Method
	  - A test to check if the correct summary string is generated and returned
  - Test_Drive_Method
	  - A test to check if the drive method is correctly incrementing the MilesDriven property
  - Test_Paint_Method
	  - A test to check if the paint method is working correctly with re-assigning the Color property. 
  
## Exercise (8 Points Possible)
In Visual Studio, clone your forked repository.  
In this solution, there is a `Vehicle` project and a `Vehicle.UnitTests` project.  The class in `Vehicle.cs` is complete, but the tests for that class are not yet finished.  Add tests to the `VehicleTests.cs` file so that all the methods and properties for the `Vehicle` class have tests.  When finished, there should be a minimum of 4 tests (one is already completed for you!).

### Submission

When completed, commit the progress you have made, and push your project to GitHub.  Instructors will be following up with some video feedback!

### Rubric

This assessment has a total of **20 Points**.  Earning **10 or more** points is a **pass** and will indicate that you are progressing well with the material.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
