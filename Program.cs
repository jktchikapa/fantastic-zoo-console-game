namespace fantastic_zoo_console_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dragon = new Animal("Draco", "Dragon", 5, 2, 2);

            dragon.Move("north", 10, 10); 
            dragon.Move("west", 10, 10);   
            dragon.Move("west", 10, 10);   
            dragon.Move("west", 10, 10);   
            dragon.DisplayInfo();  
        }
    }
}
