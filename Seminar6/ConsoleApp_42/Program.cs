/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.*/
string GetDvoich(int x)
{
    int ost = 0;
    string rez = "";
    while (x != 0)
    {
        ost = x % 2;
        x = x / 2;
        rez = ost.ToString() + rez;
    }
    return rez;
}
Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
string otvet = GetDvoich(x);
System.Console.WriteLine(otvet);