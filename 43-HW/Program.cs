// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// y=5*x+2
// y=9*x+4

// 5*x+2=9*x+4
// 5x=9x+2
// -4x=2
// x=-0.5

// y=5*(-0.5)+2

// y=-2.5+2
// y=(-0.5)

Console.WriteLine("Программа выведет на экран точку пересечения двух прямых, заданных уровнениями");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем");
Console.WriteLine("Ниже введите значения  b1, k1, b2 и k2 - целые числа");

Console.Write("Введи число b1 ");//приглашение для польз вввести число b1
double b1 = int.Parse(Console.ReadLine());//Записали число b1

Console.Write("Введи число k1 ");//приглашение для польз вввести число k1
double k1 = int.Parse(Console.ReadLine());//Записали число k1

Console.Write("Введи число b2 ");//приглашение для польз вввести число b2
double b2 = int.Parse(Console.ReadLine());//Записали число b2

Console.Write("Введи число k2 ");//приглашение для польз вввести число k2
double k2 = int.Parse(Console.ReadLine());//Записали число k2


// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// y=5*x+2
// y=9*x+4

// 5*x+2=9*x+4
// 5x+2=9x+4
// -4x=4-2
// x=(4-2)/4
// 5x=9x+2
// -4x=2
// x=-0.5

// y=5*(-0.5)+2

// y=-2.5+2
// y=(-0.5)

// y = k1 * x + b1, 
// y = k2 * x + b2; 
// k1 * x + b1 = k2 * x + b2
// k1 * x = k2 * x + b2 - b1
// k1*x - k2*x = b2 - b1
// x= (b2-b1)/(k1-k2)
//

//  string TochkaXY (double b1, double k1, double b2, double k2)
//  {
  double CoordX=0;
  double CoordY=0;
  CoordX= (b2-b1)/(k1-k2);
  CoordY=(k2*CoordX+4);
  string CoordXY=Convert.ToString(CoordX);
  //string TochkaXY =(CoordX, CoordY);
  //return (CoordXY);
//   }
// string TochkaXY1 = (TochkaXY(b1, k1, b2, k2));

//double res = TochkaXY(b1,k1,b2,k2);


// Console.Write(CoordX);
// Console.Write(CoordY);
//Console.WriteLine(TochkaXY);

Console.WriteLine($"Точка пересечения прямых  ({CoordX} ; {CoordY})");