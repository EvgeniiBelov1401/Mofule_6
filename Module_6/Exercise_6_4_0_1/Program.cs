namespace Exercise_6_4_0_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            Console.WriteLine(a);

            object o = a; 
            Console.WriteLine(o);

            object o1=o;
            o1 = 321;
            Console.WriteLine(o1+" "+o);

            int b = (int)o;
            Console.WriteLine(b);


        }
    }
}
