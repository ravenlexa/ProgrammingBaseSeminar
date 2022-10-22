/* Напишите программу, которая на вход принимает число 
   и выдаёт его квадрат (число умноженное на само себя).*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Вычисление квадрата числа
int sqr = number * number;
System.Console.WriteLine($"Квадрат вашего числа = {sqr}");



