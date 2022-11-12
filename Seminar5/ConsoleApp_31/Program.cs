﻿/*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива. */
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    System.Console.Write(array[i] + " ");
}

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive += array[i];
    }
    if (array[i] < 0)
    {
        sumNegative += array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных = {sumPositive}");
System.Console.WriteLine($"Сумма отрицательных = {sumNegative}");
