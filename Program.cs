﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


                                        //Задача 34:
    /*  int count = 0;
        
        int Met(int[] array)
        {
            for  (int i = 0; i< array.GetLength(0); i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
        return count;
        }
        
        int[] Met2()
        {
            int[] array = new int [4];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100,999);
            }
            return  array;
        }
        
            
            Met(Met2());
            Console.WriteLine("количество чётных чисел в массиве = " + count); */


                                            //Задача 36: 
    /* int sum = 0;
        
        int Met(int[] array)
        {
            for  (int i = 0; i< array.GetLength(0); i++)
            {
                
                if (i % 2 == 0)
                {
                    sum= sum + array[i];
                }
            }
        return sum;
        
        }
        
        int[] Met2()
        {
            int[] array = new int [4];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100,999);
            }
            return  array;
        }
        
            
            Met(Met2());
            Console.WriteLine("sum=" + sum);// первый и третий элемент массива {1й,2,3й,4}
             */
           
                                //Задача 38:
        