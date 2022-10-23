/*Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.*/

System.Console.WriteLine("Введите числа, чтобы понять является одно число корнем другого");
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 != number2 * number2 && number2 != number1 * number1)
    {
        System.Console.WriteLine("Ни одно число не является корнем другого");
    }
else
{
    if (number1 == number2 * number2)
    {
        System.Console.WriteLine($"{number2} является корнем {number1}");
    }

    if (number2 == number1 * number1)
    {
        System.Console.WriteLine($"{number1} является корнем {number2}");
    }
    
}