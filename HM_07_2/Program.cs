Console.Clear();
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, "
+ "и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.Write("Введите количество строк: ");
int m= int.Parse(Console.ReadLine());

while (m <0){
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}

Console.Write("Введите количество столбцов: ");
int n= int.Parse(Console.ReadLine());

while (n <0){
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

Console.Write("Введите минимальное значение: ");
int minValue= int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int maxValue= int.Parse(Console.ReadLine());

int[,] RandomArray(int m, int n, int minValue, int maxValue)
{
    int[,]res= new int[m,n];
for(int i=0; i<m;i++)
{
    for(int j=0; j<n;j++)
    {
    res[i,j]=  new Random().Next(minValue,maxValue+1 );
    }
}
return res;
}

void PrintArray(int[,] array) 
{
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
    Console.Write(array[i, j]+" ");
    }
    Console.WriteLine();
  }
}
void FindElement(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); ++i) 
    {
    for (int j = 0; j < array.GetLength(1); ++j) 
    {
        if(x==i&& y==j)
        {
        Console.WriteLine("На позиции "+x +","+y +" находится элемент "+array[i,j]);
        }
    }
    }
}

int[,] arr = new int[m,n];
arr=RandomArray(m,n, minValue, maxValue);
PrintArray(arr);

Console.Write("Введите искомое число х: ");
int x= int.Parse(Console.ReadLine());

Console.Write("Введите искомое число y: ");
int y= int.Parse(Console.ReadLine());

if(x<=n&& y<=m)
{
x=x-1;
y=y-1;
FindElement(arr,x,y);
}
else{
    Console.WriteLine("Такой позиции в массиве нет");
}