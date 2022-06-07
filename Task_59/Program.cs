// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент
// массива.

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
            array[i, j] = rnd.Next(10);

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

int[,] ChangeRowArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    return array;
}

void ResoveRowColMinList(int[,] array)
{
    int[,] newarr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int min = array[0, 0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                imin = i;
                jmin = j;
            }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != imin)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != jmin)
                    Console.Write(array[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
ResoveRowColMinList(array);
