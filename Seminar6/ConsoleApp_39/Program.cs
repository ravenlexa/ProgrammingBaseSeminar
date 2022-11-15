/*Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)*/
void PrintArray(int[] array)
{
    Console.Write("Массив перевертыш: ");

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
Console.Write("           Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    System.Console.Write(array[i] + ", ");
}

for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}
System.Console.WriteLine();
PrintArray(array);
