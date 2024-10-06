Robot Name Generator
This project implements a Robot class that generates unique names for robots. Each robot is assigned a name that consists of two uppercase letters followed by a three-digit number (e.g., AB123). The name is guaranteed to be unique and can be reset to a new unique name if needed.

Table of Contents
Description
Project Structure
Features
Usage
Example Output
How to Run
Dependencies
Description
The Robot class uses a combination of letters and numbers to create a unique name for each instance. The names are stored in a HashSet to ensure no duplicates are assigned. When the robot's name is reset, the old name is removed from the set, and a new one is generated.

Key Concepts Covered:
HashSet: To keep track of used names.
Random Number Generation: For generating unique name combinations.
Static Fields: Used for shared data among instances of the class.
Properties and Methods: To encapsulate the class functionality.
Project Structure
The project contains the following files:

bash
Copy code
robot_name/
├── Program.cs          # Entry point of the application.
├── Robot.cs            # Implementation of the Robot class.
└── README.md           # This documentation file.
Features
Unique Name Generation: Each robot instance is assigned a unique name.
Name Reset: A robot’s name can be reset, generating a new unique name.
Randomized Names: Each name is a random combination of letters and numbers.
Usage
To use this class, simply create a new instance of the Robot class, and access the Name property. You can also reset the robot's name using the Reset() method.

csharp
