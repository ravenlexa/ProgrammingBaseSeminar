/*Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.*/
int LengthNumber(int number)
{
    string strNumber = Math.Abs(number).ToString();
    return strNumber.Length;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = LengthNumber(number);
System.Console.WriteLine(sum);