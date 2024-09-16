namespace OopShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ellipse shape = new Ellipse(2, 3);
            Console.WriteLine(shape.Area());
        }
    }
}