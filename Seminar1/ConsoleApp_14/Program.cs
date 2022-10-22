System.Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    System.Console.WriteLine("Кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Не кратно");
}