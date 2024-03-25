namespace Exercise_6_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle.Square()+"\n");

            rectangle= new Rectangle(2,3);
            Console.WriteLine(rectangle.Square() + "\n");

            rectangle = new Rectangle(10);
            Console.WriteLine(rectangle.Square() + "\n");
        }
    }
}
