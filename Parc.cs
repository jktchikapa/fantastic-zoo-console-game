using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantastic_zoo_console_game
{
    internal class Parc
    {
        private static List<Animal> animalList = new List<Animal>();

        public static void AddAnimal()
        {
            Utils.AskAnimalInfo(out string name, out string species, out int age, out int positionX, out int positionY);
            Animal newAnimal = new Animal(name, species, age, positionX, positionY);

            animalList.Add(newAnimal);
            View.DisplaySuccessMessage($"{name} has been added to the zoo !");
        }

        public static void SearAnimal()
        {
            Utils.AskAnimalInfo(out string name, out string species, out int age, out int positionX, out int positionY);
            if (Utils.AnimalExist(name, animalList))
            {

            }
        }

    }
}
