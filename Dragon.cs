using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantastic_zoo_console_game
{
    internal class Dragon : Animal
    {
        public int FirePower { get; set; }

        public Dragon(string name, int age, int x, int y, int firePower)
            : base(name, "Dragon", age, x, y)
        {
            this.FirePower = firePower;
        }
        public void BreatheFire()
        {
            Console.WriteLine("");
        }
    }
}
