// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1%number2 == 0)
{
    System.Console.Write($"{number1}, {number2}, кратно ");
}
else if (number1%number2 != 0)
{
    int Ostatok = number1/number2;
    System.Console.Write($"{number1}, {number2} не кратно,  остаток {Ostatok} ");
}
