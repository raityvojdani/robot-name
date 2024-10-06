using System;
using System.Collections.Generic;

namespace robot_name
{
    // The Robot class represents a robot that is assigned a unique name.
    internal class Robot
    {
        // A static HashSet to keep track of all previously used robot names.
        private static HashSet<string> usedNames = new HashSet<string>();

        // A static instance of Random to generate random letters and numbers for robot names.
        private static Random random = new Random();

        // Stores the name of the current robot instance.
        private string _name;

        // Property to access the robot's name. Generates a unique name if not already assigned.
        public string Name
        {
            get
            {
                // If the robot does not have a name yet, generate one.
                if (_name == null)
                {
                    _name = GenerateUniqueName();
                }
                // Return the robot's name.
                return _name;
            }
        }

        // Resets the robot's name by removing the old name from usedNames and assigning a new one.
        public void Reset()
        {
            // Remove the current name from the set of used names.
            usedNames.Remove(_name);

            // Generate and assign a new unique name.
            _name = GenerateUniqueName();
        }

        // Generates a unique name for the robot that hasn't been used before.
        private string GenerateUniqueName()
        {
            string newName;

            // Continue generating names until a unique one is found.
            do
            {
                newName = GenerateName();
            }
            while (usedNames.Contains(newName)); // Check if the name is already in use.

            // Add the new name to the set of used names.
            usedNames.Add(newName);

            // Return the unique name.
            return newName;
        }

        // Generates a random name in the format of two uppercase letters followed by three digits.
        private string GenerateName()
        {
            // Generate two random uppercase letters.
            char letter1 = (char)('A' + random.Next(0, 26));
            char letter2 = (char)('A' + random.Next(0, 26));

            // Generate a random three-digit number.
            int number = random.Next(100, 1000);

            // Return the formatted name (e.g., "AB123").
            return $"{letter1}{letter2}{number}";
        }
    }
}
