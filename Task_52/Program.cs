// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] Array = new int[3,4];
 
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Array[i, j] = random.Next(10);
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
}
Console.WriteLine("Найдем среднее арифметическое элементов в каждом столбце:");
for (int j = 0; j < Array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        sum += Array[i, j];
    }
    Console.Write($"{ sum / Array.GetLength(0)} ");
}
Console.ReadLine();
