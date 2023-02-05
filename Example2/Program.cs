// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Случайное число: {number}");

int numberFirst = number/100;
int numberSecond = number/10-numberFirst*10;
int numberThird = number%10;

System.Console.WriteLine($"{numberFirst}{numberThird}");

