// Если введено положительное число, возводим его в квадрат

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()); // number = Convert.ToInt32(Console.Readline());
if (number >= 0)
{
    number *= number; // number = number * number
    Console.WriteLine("Число возведенное в квадрат: " + number);
}
else
{
    Console.WriteLine("Число отрицательное");
    }
