namespace Exercise_6_0_1
{
    internal class Program
    {
        static void Show(int? obj)
        {
            Console.WriteLine($"{obj ?? null}\n");
        }
        static void Main(string[] args)
        {
            int? a = null;
            Show(a);
            a = 10;
            Show(a);
            
        }
    }
}
