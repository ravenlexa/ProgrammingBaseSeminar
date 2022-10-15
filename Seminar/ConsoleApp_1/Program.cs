//

Console.WriteLine("Давайте узнаем какое из двух чисел больше: ");
Console.Write("Введите 1 число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB)
{
    Console.WriteLine("они равны");    
}
if (numberA > numberB)
{
    Console.Write("max ");
    Console.WriteLine(numberA);
}
if (numberA < numberB)
{   
    Console.Write("max ");
    Console.WriteLine(numberB);
}




