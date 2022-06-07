// Задайте двумерный массив. Напишите программу, которая
// заменит строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя

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

int[,] ChangeRowColArray(int[,] array)
{
    // if (array.GetLength(0) != array.GetLength(1))
    // return array;


int[,] newarr = new int[array.GetLength(1), array.GetLength(0)];
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        newarr[i,j] = array[j,i];
    }
}
return newarr;
}

int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine("Новый Массив: ");
int[,] newarr = ChangeRowColArray(array);
PrintArray(newarr);
