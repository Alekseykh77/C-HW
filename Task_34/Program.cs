/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
 [345, 897, 568, 234] -> 2 */
 
int[] GenerateRandomArray(int size, int start, int end)
{
    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
        }
        return RandomArray;
        }

            int CountOfEven(int[] myArray2)
            {
                int Count = 0;
                for (int i = 0; i < myArray2.Length; i++)
                    if (myArray2[i] % 2 == 0)
                    {
                        Count = Count + 1;
                    }
                return Count;
            }

            int[] myArray = new int[4];
            myArray = GenerateRandomArray(4, 100, 999);
            Console.WriteLine(string.Join(", ", myArray));
            Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));
           
