Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
Console.WriteLine($"Максимальное число {a}");
}
if (a < b)
{
Console.WriteLine($"Максимальное число {b}"); 
}
else
{
    Console.WriteLine("Введено два одинаковых числа");
}