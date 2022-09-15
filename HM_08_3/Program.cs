Console.Clear();
Console.WriteLine("Задача 58: Задайте две матрицы."
+ "Напишите программу, которая будет находить произведение двух матриц.");

//Вводданных для первой матрицы
Console.Write("Введите количество строк первой матрицы: ");
int m1 = int.Parse(Console.ReadLine());

while (m1 < 0)
{
    Console.WriteLine(" введите положительное число");
    m1 = int.Parse(Console.ReadLine());
}
Console.Write("Введите количество столбцов первой матрицы: ");
int n1 = int.Parse(Console.ReadLine());

while (n1 < 0)
{
    Console.WriteLine(" введите положительное число");
    n1 = int.Parse(Console.ReadLine());
}
Console.Write("Введите минимальное значение первой матрицы: ");
int minValue1 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное первой значение: ");
int maxValue1 = int.Parse(Console.ReadLine());

//Ввод данных для второй матрицы
Console.Write("Введите количество строк второй матрицы, равное количеству столбцов первой матрицы: ");
int m2 = int.Parse(Console.ReadLine());

if(m2==n1)
{
   Console.WriteLine("Количество столбцов первой матрицы совпадает с количеством строк второй,"
   + "матрицы можно перемножить"); 
}
else{
  Console.WriteLine("Количество столбцов первой матрицы не совпадает с количеством строк второй,"
  + "матрицы невозможно перемножить");   
}
while (m2!=n1)
{
    Console.WriteLine("Введите количество строк второй матрицы, равное количеству столбцов первой матрицы: ");
    m2 = int.Parse(Console.ReadLine());
}

Console.Write("Введите количество столбцов второй матрицы: ");
int n2 = int.Parse(Console.ReadLine());
while (n2 < 0)
{
    Console.WriteLine(" введите положительное число");
    n2 = int.Parse(Console.ReadLine());
}

Console.Write("Введите минимальное значение второй матрицы: ");
int minValue2 = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное второй значение: ");
int maxValue2 = int.Parse(Console.ReadLine());

//Заполнение матрицы рандомными числами
int[,] RandomArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
//Печать матрицы
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[m1, n1];
array1 = RandomArray(m1, n1, minValue1, maxValue1);
Console.WriteLine("Первая матрица:");
PrintArray(array1);

int[,] array2 = new int[m2, n2];
array2 = RandomArray(m2, n2, minValue2, maxValue2);
Console.WriteLine("Вторая матрица:");
PrintArray(array2);

// перемножения матриц
Console.WriteLine("Произведение матриц равно: ");
int[,] Mltp = new int[m1, n2];
    for (int i = 0; i < m1; i++)
    {
        for (int j = 0; j < n2; j++)
        {
            for(int k=0;k<n1;++k){
                Mltp[i, j]=Mltp[i, j]+array1[i,k]*array2[k,j];
            }
            
        }
    }
PrintArray(Mltp);