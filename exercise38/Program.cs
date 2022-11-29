// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] NewRandomDouble( int size, int min, int max)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble()*(max-min)+ min, 2);
    }
    return arr;
}
void PrintArray(double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}. ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
Console.Write("Write array on print: ");
double [] array = NewRandomDouble(5, 100, 999);
PrintArray (array);

double MaxDigit(double []arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}
double MinDigit(double[]arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}
double max = MaxDigit (array);
double min = MinDigit (array);
double result = max - min;
Console.Write(@$"difference between max and  min array: {Math.Round(result, 2)}");