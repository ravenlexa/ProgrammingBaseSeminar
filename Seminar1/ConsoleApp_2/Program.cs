/* Напишите программу, которая будет выдавать название 
дня недели по заданному номеру.*/

System.Console.WriteLine("Введите День недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());
if (numberWeek > 7 || numberWeek < 1)
{
    System.Console.WriteLine("Такого дня недели нет");
}
else
{
    if (numberWeek == 1)
    {
        System.Console.WriteLine("Понедельник");
    }
    if (numberWeek == 2)
    {
        System.Console.WriteLine("Вторник");
    }if (numberWeek == 3)
    {
        System.Console.WriteLine("Среда");
    }if (numberWeek == 4)
    {
        System.Console.WriteLine("Четверг");
    }if (numberWeek == 5)
    {
        System.Console.WriteLine("Пятница");
    }if (numberWeek == 6)
    {
        System.Console.WriteLine("Суббота");
    }if (numberWeek == 7)
    {
        System.Console.WriteLine("Воскресенье");
    }

}


