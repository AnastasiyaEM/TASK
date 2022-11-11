// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

// Заполнение массива для треугольниками

void FillTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        triangle[i, 0] = 1; //заполнение 1-го столбца
        triangle[i, i] = 1; //диагональ (граница трегольника в матрице)
    }

    for (int i = 2; i < triangle.GetLength(0); i++) // начинаем заполнение треугольнико со второй строки 
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle(int[,] triangle) // Вывод треугольника Паскаля
{
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j < triangle.GetLength(0); j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($" {triangle[i, j]}");
        }
        Console.WriteLine();
    }
}


void IsoscelesTriangle(int [,] triangle, int cellWidth) // Вывод равнобедренного треугольника 
{
    int col = cellWidth * triangle.GetLength(0);
    for (int i = 0; i < triangle.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition (col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i,j]}");
            col += cellWidth * 2;
        }
         col = cellWidth * triangle.GetLength(0) - cellWidth * (i+1);
    }
   
    Console.WriteLine();
}

Console.Write("Введите кол-во строк треугольника: ");
int line = int.Parse(Console.ReadLine() ?? "0");
const int cellWith = 8;

int[,] triangle = new int[line, line];

FillTriangle(triangle);
PrintTriangle(triangle);
IsoscelesTriangle(triangle,cellWith);