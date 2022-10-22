// <Возвращаемый тип> <Наименование метода>(переменные) {тело метода} 
// Получить номер четверти на плоскости
int GetPointArea(int coordX, int coordY)
{
    int numberArea = 0;
    if (coordX > 0 && coordY > 0)
    {
        numberArea = 1;
    }

    if (coordX < 0 && coordY > 0)
    {
        numberArea = 2;
    }

    if (coordX < 0 && coordY < 0)
    {
        numberArea = 3;
    }

    if (coordX > 0 && coordY < 0)
    {
        numberArea = 4;
    }
    return numberArea;
}

System.Console.WriteLine( "Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine( "Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);
System.Console.WriteLine(numberArea);


