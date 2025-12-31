using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace fantastic_zoo_console_game
{
    internal class Utils
    {
        public static void WaitForKeyPress(string message = "Press a key to continue ...")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static string ReadNonEmptyInput(string prompt)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                View.DisplayError("The input should not be empty. Try again.");
            }
        }

        public static int ReadInt32Number(string prompt)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine().Trim();

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                View.DisplayError("The input should be a interger. Try again.");
            }
        }

        public static int ValidPosition(string prompt)
        {
            string input;
            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {

                }
            }
        }

        public static void AskAnimalInfo(out string name, out string species, out int age, out int positionX, out int positionY)
        {
            name = ReadNonEmptyInput("Animal' name :");
            species = ReadNonEmptyInput("Animal'species :");
            age = ReadInt32Number("Animal'age :");
            positionX = ValidPosition("Animal'position x :");
            positionY = ValidPosition("Animal'position x :");

        }

        public static bool AnimalExist(string animalName, List<Animal> animalList)
        {
            foreach(Animal animal in animalList)
            {
                if (animal.Name.ToLower() == animalName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
