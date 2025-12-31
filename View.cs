using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fantastic_zoo_console_game
{
    internal class View
    {
        public static void DisplayError(string message = "Invalid choice, please try again")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void DisplaySuccessMessage(string message = "")
        {
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
