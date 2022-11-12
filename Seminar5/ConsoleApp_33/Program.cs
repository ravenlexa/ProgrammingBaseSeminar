/*Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.*/
bool Search(int[] array, int Num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Num)
        {
            return true;   
        }
    }
    return false;       

}



int[] array = new int[9] {12, 23, -45, 6, -47, 3, 82, -73, -6};
System.Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool SearchNum = Search(array, num);
System.Console.WriteLine(SearchNum);

