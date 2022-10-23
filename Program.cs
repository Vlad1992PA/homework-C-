
/*                                lesson№6

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//          Задача 41:

/*         string num = String.Empty;
        int count = 0;

        int MetIntNum (string num1)
        {
            int int_x1 = Convert.ToInt32(num1);
            //int count = 0;
            
            if (int_x1 > 0)
            {
                count++;
            }
            return count;

        }       


      int MetStrNum(string nums)
      {

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != ',')
            {
                num = num + nums[i];
                //Console.WriteLine("num = : " + num);           
            }
            else
            {
                count = MetIntNum (num);
                num = String.Empty;
            }
                
        }

        if (Convert.ToInt32(num) > 0)
        {
            count= count +1;
        }

        return count;

      }
      Console.WriteLine("введите координаты первой точки через , : ");
      string nums = Console.ReadLine();

      MetStrNum(nums);
      Console.WriteLine("num = : " + count);
 */

//          Задача 43:

            Console.WriteLine("Ведите точку k1: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите точку k2: ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите точку b1: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите точку b2: ");
            int b2 = Convert.ToInt32(Console.ReadLine());


        double  GetPointX(int k1, int k2, int b1, int b2)
        {
            double  x=(b2-b1)/(k1-k2);
            return x;
        }

        double  GetPointY(int k1, int k2, int b1, int b2)
        {
            double  y= k1*(b2-b1)/(k1-k2)+b1;
            return y;
        }

        Console.WriteLine("Точка пересечения двух прямых: " + GetPointX(k1, k2, b1, b2) + ", "+ GetPointY(k1, k2, b1,  b2));
