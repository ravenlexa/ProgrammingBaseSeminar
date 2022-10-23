/*Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления. */ 
System.Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
int ostatok = a % b;
if (a % b == 0)
{
    System.Console.WriteLine($"Чиcло {a} кратно числу {b}");
}
else
{
    System.Console.WriteLine($"Остаток от деления {a} на {b} равен {ostatok}");
}