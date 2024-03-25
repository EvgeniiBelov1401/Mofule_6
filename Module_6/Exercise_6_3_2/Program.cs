namespace Exercise_6_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus(new Load(false ,10));
            bus.PrintStatus();
        }
    }
}
