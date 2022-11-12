/*Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.*/
int[] array = new int [new Random().Next(5, 11)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
    System.Console.Write(array[i] + " ");
}
int lenght2 = 1;
if (array.Length % 2 == 0)
{
    lenght2 = (array.Length / 2);
}
else
{
    lenght2 = (array.Length / 2 + 1);
}
System.Console.WriteLine();
int[] array2 = new int[lenght2];
int ai = array.Length - 1;
for (int i = 0; i < lenght2; i++)
{
    if (i == ai)
    {
        array2[i] = array[i];
    }
    else
    {
        array2[i] = array[i] * array[ai];
        ai = ai - 1;
    }
    System.Console.Write(array2[i] + " ");
}

