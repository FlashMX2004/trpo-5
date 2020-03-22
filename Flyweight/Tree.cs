namespace Flyweight
{
    /// <summary>
    /// Tree class. This is a client of flyweight
    /// </summary>
    public class Tree
    {
        // Extrinsic state
        public double x, y, angle;
        // Flyweight
        public TreeFlyweight flyweight;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="flyweight">Tree flyweight</param>
        public Tree(string name) => this.flyweight = FlyweightFactory.instance.GetFlyweight(name);

        /// <summary>
        /// Draw method. Draws tree on canvas
        /// </summary>
        public void Draw() => flyweight.Draw(x, y, angle);
    }
}
