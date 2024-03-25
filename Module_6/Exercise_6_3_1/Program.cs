namespace Exercise_6_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
    var department = GetCurrentDepartment();

            static Department GetCurrentDepartment()
            {
                return  new Department(new Company("Банк", "СБЕР"), new City("Санкт-Петербург"));
            }

            if (department?.Company?.Type=="Банк" && department?.City?.Name=="Санкт-Петербург")
            {
                Console.WriteLine($"У банка {department?.Company?.Name ?? "Неизвестная компания"} есть отделение " +
                    $"в городе {department?.City?.Name}");

            }
        }
    }
}
