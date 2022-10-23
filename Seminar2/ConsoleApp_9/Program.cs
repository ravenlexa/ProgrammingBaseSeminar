/*Напишите программу, которая выводит случайное число из 
  отрезка [10, 99] и показывает наибольшую цифру числа.*/
//Случайное число
int number = new Random().Next(10, 100);
int a1 = number / 10;
int a2 = number % 10;
System.Console.WriteLine(number);
if (a1 > a2)
{
    System.Console.WriteLine($"Наибольшая цифра в числе: {a1}");
}
if (a2 > a1)
{
    System.Console.WriteLine($"Наибольшая цифра в числе: {a2}");
}
if (a1 == a2)
{
    System.Console.WriteLine("Цифры равны");
}
