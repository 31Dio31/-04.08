// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int rannum=new Random().Next(10, 100);
int num1 = rannum % 10;
int num2 = rannum / 10;
System.Console.WriteLine($"Выбрано число: {rannum}");
System.Console.WriteLine (num1 > num2 ? num1 : num2);

