// Найти расстояние между точками в пространстве 2D/3D
// Задача представлена для 3D пространства, для 2D будет почти эдентична,
// только формула и входные данные меняются

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");
int Coordinate(string coorName, string pointName)
{
    Console.Write($" {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
  {
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
  }
double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка  {segmentLength}");

// По двум заданным числам проверять является ли первое квадратом второго 
// Данную задчу решали в прошлый раз - тут функция вроде и не нужна.
//  Console.WriteLine("Введите 1-ое число ");
    // int numberA = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите 2-ое число ");
    // int numberB = Convert.ToInt32(Console.ReadLine());
    // if (numberA == numberB * numberB)
    //     {
    //         Console.WriteLine("Da");
    //     }
    // else 
    //     {
    //         Console.WriteLine("net");
    //     }