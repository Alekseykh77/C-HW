/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76 */

double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(0, 100);
  }

void PrintArry(double[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(" ");
    }
  }
  Console.Write("]");
} 
PrintArry(arrayRealNumbers);

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }
  Console.WriteLine($"\nМаксмальный элемент равен {maxNumber}");
  Console.WriteLine($"Минимальный элемент равен {minNumber}");

  double decision = maxNumber - minNumber;

  Console.WriteLine($"Разница между максимальным {maxNumber} и минимальным {minNumber} элементом, равна {decision}");
