// задача 59 решение преподавателя

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}
static int GetMinValueMatrix(int[,] matrix, out int indexJ, out int indexI)
{
    indexJ = 0;
    indexI = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    return min;
}

static int[,] CutLeastElementCross(int[,] matrix)
{
    if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
    {
        int[,] emptyMatrix = { { 0 } };
        return emptyMatrix;
    }


    int min = GetMinValueMatrix(matrix, out var indexJ, out var indexI);
    Console.WriteLine($"Минимальное значение массива = {min}\nРяд - {indexI + 1}, столбец - {indexJ + 1} ");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int flagI;
            int flagJ;
            if (i >= indexI) flagI = 1;
            else flagI = 0;

            if (j >= indexJ) flagJ = 1;
            else flagJ = 0;

            resultMatrix[i, j] = matrix[i + flagI, j + flagJ];
        }
    }
    return resultMatrix;
}
int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
int[,] matrix2 = CutLeastElementCross(matrix1);
PrintMatrix(matrix2);

// заменить matrix на array 