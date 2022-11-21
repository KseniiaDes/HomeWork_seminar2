//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    num = Math.Abs(num) / 10;
    return num = num % 10;
}

if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
{
    int result = SecondDigit(number);
    Console.WriteLine($"Вторая цифра: {result}");
}
else Console.WriteLine("Пожалуйста, введите трехзначное число");
