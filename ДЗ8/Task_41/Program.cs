// Найти произведение двух матриц

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

int[,] MultiplicationArray(int[,] matrA, int[,] matrB, int[,] matrC)
{
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            matrC[i, j] = 0;

            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return matrC;
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}


int line = ReadIntegerNumber("Введите кол-во элеменов по оси x : ");
int column = ReadIntegerNumber("Введите кол-во элеменов по оси y : ");

int[,] matrA = new int[line, column];
int[,] matrB = new int[line, column];
int [,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];

FillArray(matrA, 1, 10);
FillArray(matrB, 5, 25);
Console.WriteLine("Матрица 1: ");
PrintArray(matrA);
Console.WriteLine();
Console.WriteLine("Матрица 2: ");
PrintArray(matrB);
Console.WriteLine("Произведение Матрицы 1 и Матрицы 2: ", MultiplicationArray(matrA, matrB, matrC));
PrintArray(matrC);
