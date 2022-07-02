// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Specify a two-dimensional array of size m*n: ");
Console.Write("Enter m (rows): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n (columns): ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the row number: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the column number: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
FillArray(array);
PrintArray(array);
if (rowPosition < 0 | rowPosition > array.GetLength(0) | columnPosition > array.GetLength(1) | columnPosition < 0)
    Console.WriteLine("Error: the specified position does not exist in the array!");
else Console.WriteLine(array[rowPosition - 1, columnPosition - 1]);