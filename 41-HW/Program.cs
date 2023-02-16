// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);

int[] GetArrayFromString(string stringArray)
{
  string[] nums = stringArray.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
  int[] res = new int[nums.Length];

  for (int i = 0; i < nums.Length; i++)
  {
    res[i]=int.Parse(nums[i]);
  }
  return res;
}


Console.WriteLine($"Введенный массив {String.Join(" ", GetArrayFromString(elements))}");//вывод на экран элементы массива

int CountBolZero (int [] arr)
{
int countBolZer = 0;
for (int i = 0; i < arr.Length; i++)
{
  if (arr[i]>0) countBolZer++;
}
return countBolZer;
}

int countB=(CountBolZero(baseArray));
Console.WriteLine($"Количество чисел >0 равно {countB}");
