﻿/*Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)*/
/*void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int []array = new int[10] {1,2,3,4,5,6,7,8,9,10};

for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1)-i];
    array[(array.Length-1)-i] = temp;
}

PrintArray(array);*/
//40
/*bool CheckTriangle(int x, int y, int z)
{
    if ((x < y + z) && (y < x + z) && (z < x + y))
    {
        return true;
    }
    else 
    {
        return false;
    }
}
Console.WriteLine("Введите x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z ");
int z = Convert.ToInt32(Console.ReadLine());


bool rez = CheckTriangle(x, y, z);
Console.WriteLine(rez);
*/

//45
/*Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());

int perv = 0;
Console.Write("{0} ", perv);
int vtor = 1;
Console.Write("{0} ", vtor);
int sum = 0;
int i = 2;
while (number > i)
{
    
    sum = perv + vtor;
                
    Console.Write("{0} ", sum);
                    
    perv = vtor;
    vtor = sum; 
    i++;               
}*/
int n = 9;

int f1 = 0;
int f2 = 1;
int f3 = 0;
 
Console.Write("0 1 ");

for (int i = 2; i < n; i++)
{
  f3 = f1 + f2;
  Console.Write(f3 + " ");
  f1 = f2;
  f2 = f3;
}
