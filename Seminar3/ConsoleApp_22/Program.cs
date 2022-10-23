/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.*/

//Квадрат чисел от 1 до n
void PrintSquaeresToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.WriteLine(i * i);
    }
}
System.Console.Write( "Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintSquaeresToConsole(number);
