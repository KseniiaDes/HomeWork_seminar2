// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число, чтобы узнать третью цифру этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    int numAbs = Math.Abs(num);
    if (numAbs < 100) return -1;
    while (numAbs > 999) numAbs = numAbs / 10;
    return numAbs % 10;
}

int result = ThirdDigit(number);
if (result == -1) Console.WriteLine("Нет третьей цифры");
else Console.WriteLine($"Третья цифра: {result}");