Console.Clear();
Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел."
+ "Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

Console.Write("Введите длинну массива: ");
int m = int.Parse(Console.ReadLine());

while (m < 0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}
Console.Write("Введите высоту массива: ");
int n = int.Parse(Console.ReadLine());

while (n < 0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

Console.Write("Введите ширину массива: ");
int l = int.Parse(Console.ReadLine());

while (l < 0)
{
    Console.WriteLine(" введите положительное число");
    l = int.Parse(Console.ReadLine());
}

Console.Write("Введите минимальное двузначное число диапазона массива: ");
int minValue = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное двузначное число диапазона массива: ");
int maxValue = int.Parse(Console.ReadLine());

//Поиск повторений  в трехмерном массиве
int FindRepeat(int i1, int j1, int k1, int[,,] array)
{
    int result = 0;

    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            for (int k = 0; k < array.GetLength(2); ++k)
            {
                if (i1 == i && j1 == j && k1 == k)
                {
                    continue;
                }
            if (array[i, j, k] == array[i1, j1, k1])
            {
                result = 1;
                return result;
            }
            }
        }
        return result;
    }
      return result;
}

//Функция заполенение трехмерного массива случайными числами
int[,,] RandomArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] res = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                res[i, j, k] = new Random().Next(minValue, maxValue + 1);
                int result = FindRepeat(i, j, k, res);
                while (result == 1)
                {
                    res[i,j,k] = new Random().Next(minValue, maxValue + 1);
                    result = FindRepeat(i, j, k, res);
                }
            }
        }
    }
    return res;
}

//функция печати массива трехмерногомассива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            for (int k = 0; k < array.GetLength(2); ++k)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ")" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array = new int[m, n, l];
array = RandomArray(m, n, l, minValue, maxValue);
Console.WriteLine("Массив из неповторяющихся чисел:");
PrintArray(array);
Console.WriteLine();