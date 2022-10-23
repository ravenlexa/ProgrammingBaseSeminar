/*Напишите программу, которая выводит случайное трёхзначное число 
  и удаляет вторую цифру этого числа.*/
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int a1 = number / 100;
int a2 = number % 10;
int result = a1 * 10 + a2;
System.Console.WriteLine(result);
