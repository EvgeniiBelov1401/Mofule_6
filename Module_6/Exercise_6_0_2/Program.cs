namespace Exercise_6_0_2
{
    internal class Program
    {
        static void AddTen(ref int num)
        {
            num = num + 10;
        }
        static void Main(string[] args)
        {
            var num = 1;
            AddTen(ref num);

            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
