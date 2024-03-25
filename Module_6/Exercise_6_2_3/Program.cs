namespace Exercise_6_2_3
{
    internal class Program
    {
        public struct Animal
        {
            public string type;
            public string name;
            public int age;
        }
        static void Main(string[] args)
        {
            Animal animal = new Animal() {type="Собака", name="Вольт", age=4};
        }
    }
}
