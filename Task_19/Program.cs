/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.Write("Введите пятизначное чило: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
    if ( number[0] == number[4] && number[1] == number[3]) // первый элемент дожен быть равен последнему и второй элемент предпоследнему
    // только если оба условия выполняются число - полиндром, знак || - или не подходит. Необходим знак && - и.
    {
        Console.WriteLine($"Ваше число: {number} - полиндром");
    }
    else Console.WriteLine($"Ваше число: {number} - не полиндром");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
    else Console.WriteLine("Введите правильное число");
