// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateMatrix (int m, int n)
{
   Random random = new Random();
   double[,] matrix = new double[m, n];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j]=random.NextDouble()*20;
        }
   }
   return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}

int m = ReadInt("enter amount of colums: ");
int n = ReadInt("enter amount of n: ");
double[,] matrix = CreateMatrix(m,n);
PrintMatrix(matrix);