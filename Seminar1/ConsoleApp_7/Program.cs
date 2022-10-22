/* Напишите программу, которая принимает на вход трёхзначное число 
   и на выходе показывает последнюю цифру этого числа.*/

System.Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int ostatok = number % 10;

if (number > 999 || number < 100)
{
    System.Console.WriteLine("Это не трехначное число");
}
else
{
    System.Console.WriteLine($"Последняя цифра {ostatok}");
}