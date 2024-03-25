namespace Exercise_6_2_0_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greeting();
            human.name = "Евгений";
            human.age = 34;
            human.Greeting();

        }
    }
}
