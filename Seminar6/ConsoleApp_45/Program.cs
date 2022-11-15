/*Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.*/
void PrintArray(int[] array)
{
    Console.Write(" Копия: ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

int[] array = new int [11];
Console.Write("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    System.Console.Write(array[i] + ", ");
}

for (int i = 0; i < array.Length -1; i++)
{
    int temp = array[i];
    //array[i] = array[(array.Length - 1) - i];
    //array[(array.Length - 1) - i] = temp;
}
System.Console.WriteLine();
PrintArray(array);

