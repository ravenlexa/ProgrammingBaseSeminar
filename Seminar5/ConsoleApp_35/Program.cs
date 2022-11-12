/*Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].*/
int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 999);
    System.Console.Write(array[i] + " ");
}

int Count(int[] array, int a1, int a2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > a1 && array[i] < a2 )
        {
            count ++;
        }
    }
    return count;
}

System.Console.WriteLine();
System.Console.WriteLine("Введите первое число из диапозона: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число из диапозона: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Количество нужных нам чисел = {Count(array, num1, num2)}");

