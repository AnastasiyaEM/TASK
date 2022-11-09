// Сформировать трехмерный массив не повторяющимися двузначными числами показать 
// его построчно на экран выводя индексы соответствующего элемента

// Со слов преподавателя, условие задачи изменено: " Сформировать трехмерный массив и вывести его на экран"


void FillArray(int[,,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(min, max);
            }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}


int x = ReadIntegerNumber("Введите кол-во элеменов по оси x : ");
int y = ReadIntegerNumber("Введите кол-во элеменов по оси y : ");
int z = ReadIntegerNumber("Введите кол-во элеменов по оси z : ");

int[,,] array = new int[x, y, z];
FillArray(array, 0, 100);
Console.WriteLine("Массив: ");
PrintArray(array);
