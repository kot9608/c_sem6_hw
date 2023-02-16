// **Задача 42:**Напишите программу,
//  которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Clear();//очистили консоль
Console.Write("Введи число ");//приглашение для польз вввести число в десятичной системе счисления
int number = int.Parse(Console.ReadLine());//Записали число польз

string res = DecToNum(number, 2);//вызов метода перевода число в другую систему счисления с числом от пользователя и системой счисления = 2

Console.WriteLine($"{number}->{res}");


string DecToNum(int decNumber, int otherSystem)
{
  string res ="";
  string nums = "0123456789ABCDEF";
  while (decNumber>0)
  {
    int ost = decNumber/otherSystem;
    res=nums[decNumber-otherSystem*ost]+res;
    decNumber/=otherSystem;
  }
  return res;
}


//Универсальный математический метод для перевода из 10тичной в любую систему счисления