// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = FillArray(10);
Print(array);
Console.WriteLine();
var count = GetCountEvenNum(array);
Console.WriteLine(count);

int GetCountEvenNum(int[] array)
{
    int count = 0;
    foreach(var num in array)
    {
        if (num  % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var num in array)
    {
        Console.Write($"{num}, ");
    }
}
