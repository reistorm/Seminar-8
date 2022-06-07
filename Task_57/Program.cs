// Составить частотный словарь элементов двумерного массива
// это дает информацию о том, сколько раз встречается
// элемент в массиве


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
void FrequencyList(int[,] array)
{
    int[] listar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int count = 0;
    for (int k = 0; k < listar.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (listar[k] == array[i,j])
                count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"{listar[k]} встречается {count} раз");

        }
        count = 0;
    }
}
int[,] array = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine();
FrequencyList(array);