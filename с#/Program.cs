// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

static void Main()
{
    Console.WriteLine("Введите значение M:");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M <= N)
    {
        for (int i = M; i <= N; i++)
        {
            Console.Write(i);
            if (i < N)
            {
                Console.Write(", ");
            }
        }
    }
    else
    {
        Console.WriteLine("M должно быть меньше или равно N.");
    }

    Console.WriteLine();
}

Main();






// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static void Main()
{
    Console.WriteLine("Введите значение M:");
    int M = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int N = Convert.ToInt32(Console.ReadLine());

    int sum = 0;

    if (M <= N)
    {
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных чисел от " + M + " до " + N + " равна: " + sum);
    }
    else
    {
        Console.WriteLine("Значение M должно быть меньше или равно значению N.");
    }
}
Main();






// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29



static int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

static void Main()
{
    Console.WriteLine("Введите значение M:");
    int m = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Введите значение N:");
    int n = Convert.ToInt32(Console.ReadLine());

    int result = Ackermann(m, n);
    Console.WriteLine($"A({m}, {n}) = {result}");
}

Main();


