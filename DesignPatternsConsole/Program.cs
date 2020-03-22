using System;
using Flyweight;

namespace DesignPatternsConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random r = new Random();

            // Create forest
            Forest forest = new Forest();

            // Plant some trees
            try
            {
                forest.PlantTree("Tree1", 1.01, 0, 0);
                forest.PlantTree("Tree3", -6.66, 19, 0);
                forest.PlantTree("Tree4", 2.71828182846, 3.14159265359, 360);
                forest.PlantTree("Not existing tree", 0, 0, 0);// Here can be an exception
            }
            catch
            {
                Console.WriteLine("Some trees can't be drawn");
            }

            // Plant more trees
            for (int i = 0; i < 10; i++)
            {
                forest.PlantTree(FlyweightFactory.instance.GetRandomName(), 
                                 r.NextDouble() * 1000, 
                                 r.NextDouble() * 1000, 
                                 r.NextDouble() * 360);
            }

            // Draw forest
            forest.Draw();

            Console.ReadKey();
        }
    }
}
