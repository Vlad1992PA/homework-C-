
/* Урок 9. Как не нужно писать код. Часть 3
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/* 
//int n = 5;
int n = 8;
int divider = 1;

void Met1(int n)
{
    Console.Write((n / divider) + ", ");
    n--;
    if (n > 1) { Met1(n); }
    else if (n > 0) { Console.Write((n / divider)); }
}
Met1(n);
 */


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* 
//int min = 4;
//int max = 8;
int min = 1;
int max = 15;
int sum = 0;

void Met1(int min, int max, int sum)
{
    if (min <= max)
    {
        sum = sum + min;
        min++;
        Met1(min, max, sum);
    }
    else { Console.WriteLine("Сумма= " + sum); }
}

Met1(min, max, sum);
 */


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/* 
//int m = 2;
//int n = 3;
int m = 3;
int n = 2;
int Akk(int m, int n)
{
  if (m == 0) {return n + 1;}
  else if (n == 0) {return Akk(m - 1, 1);}
  else {return Akk(m - 1, Akk(m, n - 1));}
}
Console.WriteLine(Akk (m, n));
*/