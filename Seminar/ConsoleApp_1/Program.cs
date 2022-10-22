/* Напишите программу, которая на вход принимает два числа 
и проверяет, является ли первое число квадратом второго.*/

System.Console.WriteLine("Введите числа, чтобы понять является одно число корнем другого");
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2 || number2 == number1 * number1)
{
    System.Console.WriteLine("Является корнем");
}

else
{
    System.Console.WriteLine("Не является корнем");
}