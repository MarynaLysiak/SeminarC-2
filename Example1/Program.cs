// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Random rand = new Random();
int number = new Random().Next(10, 100); //  от 10 до 99, полуинтервал [10, 100)
System.Console.WriteLine($"Случайное число: {number}"); // $ - форматированная строка

int leftNumber = number/10;
int rightNumber = number%10;

// промежуточная отладка System.Console.WriteLine($"{leftNumber} {rightNumber}");

 if (rightNumber>leftNumber)
 {
    System.Console.WriteLine($"В слуйчайном числе {number} найбольшая цифра {rightNumber}");
 }
else if (leftNumber>rightNumber)
{
    System.Console.WriteLine($"В случайном числе {number} найбольшая цифра {leftNumber}");
}
else
{
    System.Console.WriteLine($"В случайном числе {number} цифры равны");
}