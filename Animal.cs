using System;

namespace fantastic_zoo_console_game
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Animal(string name, string species, int age, int newX, int newY)
        {
            Name = name;
            Species = species;
            Age = age;
            PositionX = newX;
            PositionY = newY;
        }

        public void DisplayInfo()
        {
            Console.Clear();
            Console.WriteLine("Animal informations");
            Console.WriteLine("====================================");
            Console.WriteLine($"Name     : {this.Name}");
            Console.WriteLine($"Species  : {this.Species}");
            Console.WriteLine($"Age      : {this.Age} years");
            Console.WriteLine($"Position : ({this.PositionX}, {this.PositionY})");
            Console.WriteLine("====================================\n");
            Utils.WaitForKeyPress();
        }

        public bool Move(string direction, int gridWidth, int gridHeight)
        {
            int newX = this.PositionX, newY = this.PositionY;

            switch (direction.ToLower())
            {
                case "up":
                case "north":
                    newY--;
                    break;
                case "down":
                case "south":
                    newY++;
                    break;
                case "right":
                case "east":
                    newX++;
                    break;
                case "left":
                case "west":
                    newX--;
                    break;
                default:
                    View.DisplayError($"Invalid direction '{direction}'! Use: north, south, east, west");
                    return false;
            }
            if (newX >= 0 && newX < gridWidth && newY >= 0 && newY < gridHeight)
            {
                PositionX = newX;
                PositionY = newY;
                Console.WriteLine($"{this.Name} moved {direction} to ({newX},{newY})");
                return true;
            }
            else
            {
                View.DisplayError($"Cannot move {direction}! Would be out of bounds at ({newX}, {newY})");
                return false;
            }
        }
    }
}
