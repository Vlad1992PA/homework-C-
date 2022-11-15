//                               lesson№8

/* Урок 8. Как не нужно писать код. Часть 2
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/* 
  int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 4, 2 } };
      
      for (int i = 0; i < array.GetLength(1); i++)
      {
        
        for (int j = 0; j <= array.GetLength(0); j++)
        {
          int num = 0;// переменная для перезаписи числа
          int count = j;// счётчик для цикла сравнения и пере
          while (count<= array.GetLength(0))
          {
            if (array[i, j] < array[i, count])
            {
              num = array[i, j];
              array[i, j] = array[i, count];
              array[i, count] = num;      
            }
            count++;
          }

          if (j < array.GetLength(0)){Console.Write(array[i, j]+ ","); }
          else if (j == array.GetLength(0)){Console.Write(array[i, j]); }
           
        }
         Console.WriteLine( );

      } */

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */
    /*   
      int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
      int[] sum = new int[4]; // задаем масив с колличеством сумм элементов массива
      int count = 0;// счётчик элементов
      
      for (int i = 0; i < array.GetLength(1); i++)
      {        
        sum[count] = 0; // обнуляем для старта новой суммы строк
        
        for (int j = 0; j < array.GetLength(0); j++)
        {
          sum[count] = sum[count] + array[i, j];
        }
        count++;
      }
      
      int comparison_sum = sum[0];// создаемзначения сравнения и приравниваем его к первому элементу массива
      int strin = 1; // условно делаем первую строку минимальной
      
      for (int i = 0; i < sum.GetLength(0); i++) {
        if (comparison_sum  >  sum[i]) {strin = i+1; comparison_sum = sum[i];}
      }
      Console.WriteLine(" Строка с наименьшей суммой элементов №:"+ strin);
 */


/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
            
/*             int[,] matrix_one = { { 2, 4 }, { 3, 2 } };
            int[,] matrix_two = { { 3, 4 }, { 3, 3 } };
            int[,] matrix_sum =  new int[2, 2];

            for (int i = 0; i < matrix_one.GetLength(1); i++)
            {
                for (int j = 0; j < matrix_one.GetLength(0); j++)
                {
                    if (i == 0 & j == 0){
                    matrix_sum[i, j] = matrix_one[0, 0] * matrix_two[0, 0] + matrix_one[0, 1] * matrix_two[1, 0];
                    Console.Write(matrix_sum[i, j]+ " ");
                    }
                    if (i == 0 & j == 1){
                    matrix_sum[i, j] = matrix_one[0, 0] * matrix_two[0, 1] + matrix_one[0, 1] * matrix_two[1, 1];
                    Console.Write(matrix_sum[i, j]+ " ");
                    }
                    if (i == 1 & j == 0){
                    matrix_sum[i, j] = matrix_one[1, 0] * matrix_two[0, 0] + matrix_one[1, 1] * matrix_two[1, 0];
                    Console.Write(matrix_sum[i, j]+ " ");
                    }
                    if (i == 1 & j == 0){
                    matrix_sum[i, j] = matrix_one[1, 0] * matrix_two[0, 1] + matrix_one[1, 1] * matrix_two[1, 1];
                    Console.Write(matrix_sum[i, j]+ " ");
                    } 
                }
                Console.WriteLine();

            } */


/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/*     Random random = new Random();
    int[,,] array = 
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            for (int z = 0; z < 2; z++)
            {
                array[x, y, z] = random.Next(10, 99);
                Console.Write($"{array[x, y, z]} ({x}, {y}, {z})  ");
            }
            Console.WriteLine();
        }
    } */


/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */

 int[,] array = new int[7, 7];
      //int[,] array = new int[5, 5];
      //int[,] array = new int[4, 4];
      int d_i = array.GetLength(1);
      int d_j = array.GetLength(0);      
      int i = 0;
      int j = 0;
      int start = 0;
      int finish = 0;
      int count = 10; // что бы не заморачиваться с 01 и выглядело ровно, а так должно равно 0
      
      int how_many_actions = d_i*d_j+count;
      Console.WriteLine("Спиральное заполнение КВАДРАТНОГО массива " + array.GetLength(1)+ "x" + array.GetLength(1) + ":");
      
      while (count < how_many_actions)      { 
        if (i==start & j < d_j)    {
          for (j = finish; j < d_j; j++)   {
            count++;            array[i,j]= count; 
          }          
          j--;          d_j--;          start++;
        }
        
        else if (j == d_j & i < d_i)    {
          d_i--;
          for (i = start; i <= d_i; i++)   {
            count++;            array[i,j]= count; 
          }
          i--;
        }        

        else if (i == d_i & j == d_j)    {
          d_j--;
          for (j = d_j; j >= finish; j--)   {
            count++;            array[i,j]= count;
          }
          j++;          d_j++;
        }        
        
        else if (i == d_i & j < d_j)    {
          d_i--;
          for (i = d_i; i >= start; i--)   {
            count++;            array[i,j]= count; 
          }
          i++;          d_i++;          finish++;
        }
      }
      
       for (int x = 0; x < array.GetLength(1); x++)  {
          for (int y = 0; y < array.GetLength(0); y++)
          {
            Console.Write(array[x, y]+ " ");
          }

          Console.WriteLine();
       }


