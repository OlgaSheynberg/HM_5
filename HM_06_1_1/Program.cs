Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("Введите число M:");
int m= int.Parse(Console.ReadLine());

while (m <0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}
int count =0;
int [] array= new int[m];
for(int i =0; i<m; i++)
{
    Console.Write("Введите "+i+" элемент массива: ");
    array[i]=int.Parse(Console.ReadLine());
    if(array[i]>0)
    {
        count++;
    }
}
Console.WriteLine("В веденной последовательности чисел: "+string.Join(", ", array));
Console.WriteLine("Количество чисел больше нуля: "+count);