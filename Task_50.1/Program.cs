//  Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
  
int[,] array = new int[3, 4];
 
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
        }
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool f = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (number == array[i, j]) { f = true; };
        
                }
            }
            if (f)
                for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] == number)
                    {
                        Console.WriteLine("Массив содержит число, его индекс: ({0},{1})", i, j);
                    }
                }
            }
            else
                Console.WriteLine("Такого числа в массиве нет");


            
            
            
            