Console.Clear();
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Введите размер массива: ");
int n =int.Parse(Console.ReadLine()); 
while (n <0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

int sum=0;
int[]array= new int[n];
for(int i=0; i<n; i++)
{
array[i]= new Random().Next(0,10);
 sum+=i%2==0?array[i]:0;
}
foreach(int e in array)
{
    Console.Write(e+" ");
}
Console.Write("Суммма элементов, стоящих на нечётных позициях в массиве равна: "+sum);