/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

7 -> 28

4 -> 10

8 -> 36

А потом выдаёт произведение чисел от 1 до А.

4 -> 24
5 -> 120*/

Console.Write("Введите число (A), программа выдаст сумму чисел от 1 до A: ");
int n = Convert.ToInt32(Console.ReadLine());
int Summ(int n)
{
     int summ = 0;
    for (int i = 1; i <= n; i++)
    {
    summ = i + summ;
    }
    return summ;
}
int Product(int n)
{
    int prod = 1;
    for (int i =1; i <= n; i++)
    {
        prod = i * prod;
    }
    return prod;
}
Console.WriteLine($"сумма от 1 до A : {Summ(n)}");
Console.WriteLine($"произведение равно: {Product(n)}");
