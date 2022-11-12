//Написать программу вычисления функции Аккермана

// функция Аккермана принимает 2 неотрицательных числа 

int Akkerman (int n, int z)
{
    if (n == 0) return z+1;
    else if (n > 0 && z > 0) return Akkerman(n - 1, Akkerman(n, z-1));
    else if (n !=0 && z == 0) return Akkerman(n - 1, 1);
    return Akkerman(n,z);
}

int ReadIntegerNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine() ?? "0");
    }

    int n = ReadIntegerNumber("Введите число n: ");
    int z = ReadIntegerNumber("Введите число z: ");

Console.WriteLine($"Вычисление значения функцией Аккермана: {Akkerman(n,z)}");
