//----------------------------------Exercise #68------------------------------
// Задача 68:**Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29
//Функция Аккермана — простой пример всюду определённой вычислимой функции, которая не является примитивно рекурсивной.
//----------------------------------SOLUTION-----------------------------------
/*
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, 1);
    if (n > 0 && m > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}
System.Console.WriteLine("Укажите m функции: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Укажите n функции: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Результат функции Аккермана для {m} и {n}  является {Akkerman(m, n)}");
*/
//----------------------------------Exercise #64------------------------------
/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
//----------------------------------SOLUTION-----------------------------------
/*
string PrintN(int N)
{
    if (N == 1) return "1";
    return Convert.ToString(N) + ", " + PrintN(N - 1);
}

System.Console.Write("Укажите начало отсчета (N): ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"N = {N} -> \"{PrintN(N)}\"");
*/
//----------------------------------Exercise #66------------------------------
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
//----------------------------------SOLUTION-----------------------------------

int SumMN(int m, int n)
{
    if (m > n) return 0;
    return n + SumMN(m, n - 1);
}
System.Console.Write("Укажите начало промжутка: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Укажите конец промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма натуральных элементов на промежутке от {m} до {n} равна {SumMN(m, n)}");