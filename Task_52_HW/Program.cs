// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Specify a two-dimensional array of size m*n: ");
Console.Write("Enter m (rows): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n (columns): ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ArithmeticMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double arithmeticMean = sum / array.GetLength(0);
        arithmeticMean = Math.Round(arithmeticMean, 1);
        Console.WriteLine($"Arithmetic mean {i + 1} columns: {arithmeticMean}");
    }
}
FillArray(array);
PrintArray(array);
ArithmeticMean(array);