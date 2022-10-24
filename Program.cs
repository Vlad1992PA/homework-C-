/*                                lesson№7

/* Урок 7. Как не нужно писать код. 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//                              Задача 47
/* 
int[,] array = new int[3, 4] { { 1, 4, 7, 2},
        { 5, 9, 2, 3}, { 8, 4, 2, 4} };

for (int j = 0; j < array.GetLength(1); j++)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ += array[i, j];
        //Console.Write($"{summ} ");
    }
    Console.WriteLine();
    Console.WriteLine(Convert.ToDouble(summ) / Convert.ToDouble(array.GetLength(0)));
} */

//                              Задача 50

/* Console.WriteLine("Введите позицию элемента встроке: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента столбце: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[3, 4] { { 1, 4, 7, 2},
        { 5, 9, 2, 3}, { 8, 4, 2, 4} };

if (i - 1 <= array.GetLength(0)) // -1 добавляется 
{
    if (j - 1 <= array.GetLength(1)) //
    {
        Console.WriteLine("Значение = " + array[i - 1, j - 1]);
    }
    else { Console.WriteLine($"Позиции элемента {j} в столбце нет!"); }
}
else { Console.WriteLine($"Позиции элемента {i} в строке нет!"); }
     */

//                              Задача 52

int[,] array = new int[3, 4] { { 1, 4, 7, 2},
        { 5, 9, 2, 3}, { 8, 4, 2, 4} };

for (int j = 0; j < array.GetLength(1); j++)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ += array[i, j];

    }

    /*  Console.WriteLine(Convert.ToDouble(summ) / Convert.ToDouble(array.GetLength(0))); 
    //показывает полное число: 4,666666666666667 */

    /*  double num = Convert.ToDouble(summ)/Convert.ToDouble(array.GetLength(0)); 
     System.Console.Write(System.Math.Round(num, 2) + "  "); // округляет до:4,67  5,67  3,67  3  */

    string num = Convert.ToString(Convert.ToDouble((summ) / Convert.ToDouble(array.GetLength(0))));
    if (num.Length > 4) { Console.Write(num[..4] + "  "); }
    else { Console.Write(num + "  "); }

}