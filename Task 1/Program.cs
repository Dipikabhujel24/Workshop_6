namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle { Length = 5, Width = 4 };
            Console.WriteLine($"Area: {r.Area}");
            Console.WriteLine($"Perimeter: {r.GetPerimeter()}");
        }
    }
}
