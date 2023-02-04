// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
int ReadInt (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()??"0");
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
int? FiendValue (int[,] matrix, int fristIndex, int secondIndex)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == fristIndex && j==secondIndex)
            {
                return matrix[i,j];
            }
        }
    }
    return null;
}
int m = ReadInt("введите m: ");
int n = ReadInt("Введите n: ");
int[,] matrix = CreateMatrix(m,n);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(matrix);
int fristIndex = ReadInt("Введите нидекс строки:");
int secondIndex = ReadInt("Введите индекс столбца: ");
Console.Write("Число стоящее на позиции ["+fristIndex+", "+secondIndex+"]: "+ FiendValue(matrix, fristIndex, secondIndex));