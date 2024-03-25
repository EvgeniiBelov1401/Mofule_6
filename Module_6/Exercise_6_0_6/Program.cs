namespace Exercise_6_0_6
{
    internal class Program
    {
        static void AddOne(out int? result)
        {
            result = 0;
            result++;
        }
        static void Main(string[] args)
        {
            int? a=null;
            Console.WriteLine(a);
            AddOne(out a);
            Console.WriteLine(a);
        }
    }
}
