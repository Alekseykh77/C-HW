﻿//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


 Console.Write("Введите число M: ");
                  int M = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число N: ");
                 int N = Convert.ToInt32(Console.ReadLine());
                    Console.Write(RecursMetod(M,N));

static int RecursMetod(int M, int N)
        {
            if (M < N)
            {
                Console.Write(M + ", ");
                M++;
                RecursMetod(M, N);
            }
            return N;
        }