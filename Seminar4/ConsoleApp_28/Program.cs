/*Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.*/
int GetFactorial(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = GetFactorial(number);
Console.WriteLine(factorial);