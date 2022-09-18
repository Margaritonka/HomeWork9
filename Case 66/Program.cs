// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 1;
int n = 5;

int Integer(int m, int n)
    {
        if (m==n+1) return 0;
       return m+Integer(m+1,n);
        
    }
Console.WriteLine(Integer(m,n));