// Написать программу, которая обменивает элементы первой строки и последней строки
int[,] CreateFillMatrix(int line, int columns)
{
    int[,]matrix = new int[line,columns];
    Random random = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(1,10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
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
int InputValue(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()??"0");
}
int[,] SwitchPositionfirstlineAndLastLine(int[,] switchMatrix, int line)
{
        for (int j = 0; j < switchMatrix.GetLength(1); j++)
        {
            int tempvariable = switchMatrix[0,j];
            switchMatrix[0,j] = switchMatrix[line-1, j];
            switchMatrix[line-1, j] = tempvariable;
        }
   return switchMatrix;
}

int line = InputValue("Введите количество строк: ");
int columns = InputValue("Введите количество столбцов: ");
int[,] mainMatrix = CreateFillMatrix(line, columns);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(mainMatrix);
Console.WriteLine("Измененная матрица: ");
PrintMatrix(SwitchPositionfirstlineAndLastLine(mainMatrix, line));