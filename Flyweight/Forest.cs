using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    /// Forest can be drawn. This is another client of flyweight
    /// </summary>
    public class Forest
    {
        /// <summary>
        /// Collection of tree
        /// </summary>
        List<Tree> trees = new List<Tree>();

        /// <summary>
        /// Adds tree at the forest
        /// </summary>
        /// <param name="name">Name of tree</param>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="angle">Angle</param>
        public void PlantTree(string name, double x, double y, double angle)
        {
            var tree = new Tree(name) { x = x, y = y, angle = angle };

            trees.Add(tree);
        }

        /// <summary>
        /// Draws forest
        /// </summary>
        public void Draw() => trees.ForEach(tree => tree.Draw());
    }
}
