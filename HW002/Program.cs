//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
int[,] CreateFillMatrix(int line, int columns)
{
    int[,] matrix = new int[line, columns];
    Random random = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
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
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int InputValue(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
int[,] SortingArrayInDescendingOrder(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0)-1; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++)
        {
            int tempvariable = 0;
            if (matrix[i, j] > matrix[i, j + 1])
            {
                tempvariable = matrix[i,j];
                matrix[i,j] = matrix[i,j+1];
                matrix[i,j+1] = tempvariable;
            }
        }
    }
    }
    return matrix;
}


int line = InputValue("Введите количество строк: ");
int columns = InputValue("Введите количество столбцов: ");
int[,] mainMatrix = CreateFillMatrix(line, columns);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(mainMatrix);
Console.WriteLine("Сортированная матрица: ");
PrintMatrix(SortingArrayInDescendingOrder(mainMatrix));