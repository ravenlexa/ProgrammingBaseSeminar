/*Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

// Принимаем номер четверти и выводим строку с диапозоном.
string DiapozonCoords(int numberArea)
{
    string diapozon = "";
    if (numberArea < 1 || numberArea > 4)
    {
        diapozon = "Нет такой четверти";
    }
    else
    {
        if (numberArea == 1)
        {
            diapozon = "coordX > 0 && coordY > 0";
        }

        if (numberArea == 2)
        {
            diapozon = "coordX > 0 && coordY < 0";
        }

        if (numberArea == 3)
        {
            diapozon = "coordX < 0 && coordY < 0";
        }

        if (numberArea == 4)
        {
            diapozon = "coordX < 0 && coordY > 0";
        }
    }
    return diapozon;
}

System.Console.WriteLine( "Введите номер четверти: ");
int numberArea = Convert.ToInt32(Console.ReadLine());

string diapozon = DiapozonCoords(numberArea);
System.Console.WriteLine(diapozon);
             