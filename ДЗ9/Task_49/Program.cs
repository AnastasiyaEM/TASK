// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем


string Numbers( int n,int A, int E, int i =3) // первые два числа известны
{
    if (n !=0)
    {
    n --;
    int sum = A+E; return sum + Numbers(n,A,E,i+1);
    }
    else return " ";
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int A = ReadIntegerNumber("Введите первый эл-т последовательности: ");
int E = ReadIntegerNumber("Введите второй эл-т последовательности: ");
int n = ReadIntegerNumber("Сколько чисел показать? : ");
Console.WriteLine (Numbers(n,A,E));
