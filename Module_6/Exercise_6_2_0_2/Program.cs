namespace Exercise_6_2_0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human=new Human("Евгений");
            human.Greetings();

            human=new Human("Евгений", 34);
            human.Greetings();
        }
    }
}
