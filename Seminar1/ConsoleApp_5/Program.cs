/* Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. */
System.Console.WriteLine("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int negativN = numberN * -1;

while (negativN <= numberN)
{
    System.Console.WriteLine(negativN);
    negativN++;
}
