using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    /// <summary>
    /// Tree flyweight factory for Flyweight pattern. Uses Singleton pattern
    /// </summary>
    public class FlyweightFactory
    {
        // Privates
        private static FlyweightFactory singleton;
        private Dictionary<string, TreeFlyweight> flyweights = new Dictionary<string, TreeFlyweight>();
        private Random random = new Random();

        // Publics
        public static FlyweightFactory instance => singleton ??= new FlyweightFactory();
        public static List<string> flyweightNames = new List<string>
        {
            "Tree1", 
            "Tree2", 
            "Tree3", 
            "Tree4"
        };

        /// <summary>
        /// Constructor
        /// </summary>
        private FlyweightFactory()
        {
            // Mesh and texture can be taken from files
            flyweights = flyweightNames.Select(n => new TreeFlyweight(n, 1, new Mesh(), new Texture()))
                                       .ToDictionary(f => f.name);
        }

        /// <summary>
        /// Flyweight factory method
        /// </summary>
        /// <param name="name">Name of tree flyeight</param>
        /// <returns>Tree flyweight</returns>
        public TreeFlyweight GetFlyweight(string name)
        {
            // Mesh and texture can be taken from files.
            // Also we can throw an exception, if we not found mesh or texture by name
            return flyweights.ContainsKey(name) ? flyweights[name] : flyweights[name] = new TreeFlyweight(name, 1, new Mesh(), new Texture());
        }

        /// <summary>
        /// Gets random name from flyweight names
        /// </summary>
        /// <returns>Flyweight name</returns>
        public string GetRandomName() => flyweightNames[random.Next(flyweightNames.Count)];
    }
}
