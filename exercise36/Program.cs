// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


var array = FillArray(6);
Print(array);
Console.WriteLine();
var count = SumLessZero(array);
Console.WriteLine(count);

int SumLessZero(int[] array)
{
    int sum = 0;
    foreach(int num in array)
    {
        if(num < 0)
        {
            sum += num;
        }
    }
    return sum;
}


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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