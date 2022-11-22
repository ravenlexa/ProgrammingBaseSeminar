/*Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.*/

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.WriteLine("Введите число строк, столбцов будет столько же: ");
int m = Convert.ToInt32(Console.ReadLine());

int n = m;
int[,] array = new int[m, n];
Console.WriteLine();
FillArray(array);
int sum = 0;
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    {
        int j = i;
        if (j == i)
        {
            sum = sum + array[i, j];
        }        
    }
}
Console.WriteLine(sum);   

