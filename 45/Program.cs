/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/



Console.Clear();//очистили консоль
Console.Write("Введите длинну массива: ");//приглашение для польз вввести длинну массива
int size_array = int.Parse(Console.ReadLine());//Записали длинну массива в переменную size_array
int[] array = GetRandomArray(size_array, 0, 10);
Console.WriteLine(String.Join(" ", array));

 int[] GetRandomArray(int size, int minValue, int maxValue)//метод по созданию рандомного массива. На вход получает (длинна массива, минимальное значение элемента, максимальное значение элемента)
{
    int[] result = new int[size];//создает массив длинной указанной на входе
    for (int i = 0; i < size; i++)//цикл для заполнения элементов массива случаными значениями
    {
        result[i] = new Random().Next(minValue, maxValue + 1); //каждое значение массива заполняется рандомным числом от мин до макс, т.к. макс не входит по умолчанию указано макс+1
    }

    return result;//возвращаем массив как результат работы метода
}

int [] CopyArray (int [] arr)
{
int[] CloneArray = new int[arr.Length];
for (int i=0;i<arr.Length;i++)
{
  CloneArray[i]=arr[i];
}
return CloneArray;
}

int[] res = (CopyArray(array));



Console.WriteLine(String.Join(" ", res));