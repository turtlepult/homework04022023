//В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int FiendMinSumElements(int[,]mainMatrix, int line)
{
    int[] sumelements = new int[line];
    for (int i = 0; i < mainMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < mainMatrix.GetLength(0); j++)
        {
            sumelements[j] += mainMatrix[j,i];
        }
    }
  int min = sumelements[0];
for (int i = 0; i < sumelements.Length; i++)
{
    if(sumelements[i]<min)
    {
        min = sumelements[i];
    }
}
for (int i = 0; i < sumelements.Length; i++)
{
    if (min==sumelements[i])
    {
        return i+1;
    }
}

    return 0;
}

while (true)
{
  Conditional:
int line = InputValue("Введите количество строк: ");
int columns = InputValue("Введите количество столбцов: ");
if (line != columns)
{
    int[,] mainMatrix = CreateFillMatrix(line, columns);
    Console.WriteLine("Ваша матрица: ");
    PrintMatrix(mainMatrix);
    Console.WriteLine();
    int xxx = FiendMinSumElements(mainMatrix,line);
    Console.WriteLine("строка с наименьшей суммой чисел - "+xxx);
    break;
}
else
{
    Console.Clear();
    Console.WriteLine("Матрица не должна быть квадратной!!! Введите другие значения");
    goto Conditional;
}
}
