// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int n = 3;
int m = 2;

int Accerman(int n, int m)
    {
        if (n == 0) return m + 1;
        if (n != 0 && m == 0) return Accerman(n - 1, 1);
        if (n > 0 && m > 0) return Accerman(n - 1, Accerman(n, m - 1));
        return Accerman(n,m);
    }

Console.WriteLine(Accerman(n,m));