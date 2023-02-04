// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
return matrix;
}
void PrintMatrix (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {    for (int j = 0; j < matrix.GetLength(1); j++)
         {
           Console.Write(matrix[i,j]+"\t");
         }
         Console.WriteLine();
    }
}
int ReadInt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
}
int[] resultMatrix(int[,] matrix, int m)
{
    int[] result = new int[m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i]+=matrix[j,i];
        }
    }
   for (int k = 0; k < result.Length; k++)
   {
        result[k] /= m;
   }
    return result;
}

int m = ReadInt("введите количество строк: ");
int n = ReadInt("Ведите количество столбцов: ");
int[,] mass = CreateMatrix(m,n);
PrintMatrix(mass);
int[] resultm = resultMatrix(mass, m);
Console.WriteLine();
foreach (var item in resultm)
{
    Console.Write(item+ "\t");
}
