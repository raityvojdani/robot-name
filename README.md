# Robot Name Generator in C#

## Project Overview

This project implements a **Robot Name Generator** in C#. The `Robot` class generates unique names for robot instances consisting of two uppercase letters followed by a three-digit number (e.g., `AB123`). Each name is guaranteed to be unique, and the robot can reset its name to generate a new one when needed.

## Key Features
1. **Unique Name Generation**: Each robot instance receives a unique name upon creation.
2. **Name Reset**: The robot can reset its name, generating a new unique name.
3. **Randomized Naming**: Names are created using a combination of random letters and numbers.
4. **Used Name Tracking**: Keeps track of names that have already been assigned to prevent duplicates.

## Class Overview

The core of this project is the `Robot` class, which allows the user to create robots and manage their names.

### Methods:

- **`string Name`**: A property that retrieves the robot's name. If the name hasn't been generated yet, it will create a new unique name.
- **`void Reset()`**: Resets the robot's name to a new unique name, removing the previous name from the used names set.
- **`private string GenerateUniqueName()`**: Generates a new unique name by checking against the names already assigned.
- **`private string GenerateName()`**: Generates a random name in the format of two uppercase letters followed by three digits.

## Example Usage

To use the `Robot` class, you can create instances and access their names as follows:



##How to Run
Clone the repository or download the source files.
Open the project in your preferred C# IDE (e.g., Visual Studio).
Set the Program.cs as the startup project.
Build and run the project.


```csharp
Robot robot1 = new Robot();
Console.WriteLine(robot1.Name); // Outputs a unique name like "AB123"

robot1.Reset();
Console.WriteLine(robot1.Name); // Outputs a new unique name like "CD456"
