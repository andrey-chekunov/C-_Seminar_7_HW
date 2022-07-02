// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Specify a two-dimensional array of size m*n: ");
Console.Write("Enter m (rows): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n (columns): ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, columns];
void FillMatrix(double[,] matrix)                       
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-10,10)) / (new Random().Next(1,11));
        }
    }
}
void PrintMatrix(double[,] matrix)                      
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:0.0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
FillMatrix(matrix);
PrintMatrix(matrix);