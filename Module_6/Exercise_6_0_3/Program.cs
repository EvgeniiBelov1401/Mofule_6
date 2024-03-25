namespace Exercise_6_0_3
{
    internal class Program
    {
        static void ShowArray(int[]arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();    
        }
        static void Main(string[] args)
        {
            int[] array0 = { 1, 2, 3, 4, 5 };
            ShowArray(array0);

            int[] array1 = array0;
            ShowArray(array1);
            array1[4] = 0;
            ShowArray(array1);
            ShowArray(array0);
        }
    }
}
