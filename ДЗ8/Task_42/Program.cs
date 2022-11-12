// В двумерном массиве целых чисел. 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] Minimalindex(int[,] array)
{
    int[] index = new int[2]; // Массив для хранения индексов минимального элемента
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

void DisplacementRowsCols(int[,] array, int[] index)
{
    for (int i = index[0]; i < array.GetLength(0) - 1; i++)
    {
        for (int j = index[1]; j < array.GetLength(1) - 1; j++)
        {
            array[i, j] = array[i + 1, j];
            array[i, j] = array[i, j + 1];
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}


int rows = ReadIntegerNumber("Введите кол-во строк: ");
int cols = ReadIntegerNumber("Введите кол-во столбцов : ");
int[,] array = new int[rows, cols];

FillArray(array, 5, 10);
Console.WriteLine("Array: ");
PrintArray(array);
int [] index = Minimalindex(array);

Console.WriteLine($"Минимальный элемент в массиве = {index}");


Print(array);