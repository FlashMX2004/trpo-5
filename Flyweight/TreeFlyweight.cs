using System;

namespace Flyweight
{
    /// <summary>
    /// Tree flyweight for Flyweight pattern
    /// </summary>
    public class TreeFlyweight
    {
        // Intrinsic state
        public string name;
        public double scale;
        public Mesh mesh;
        public Texture texture;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of tree</param>
        /// <param name="scale">Scale of tree</param>
        /// <param name="mesh">Mesh of tree</param>
        /// <param name="texture">Texture 2d for tree</param>
        public TreeFlyweight(string name, double scale, Mesh mesh, Texture texture)
        {
            this.name = name;
            this.scale = scale;
            this.mesh = mesh;
            this.texture = texture;
        }

        /// <summary>
        /// Draw method take extrinsic state by parameters. Draws tree on canvas
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="angle">Angle of tree</param>
        public void Draw(double x, double y, double angle)
        {
            Console.WriteLine($"Tree {name} at ({x}, {y}) with angle {angle} was drawn");
        }
    }

    /// <summary>
    /// Mesh class
    /// </summary>
    public class Mesh
    {
        //...
    }

    /// <summary>
    /// Texture class
    /// </summary>
    public class Texture
    {
        //...
    }
}
