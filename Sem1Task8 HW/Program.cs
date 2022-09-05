﻿//====================================================
// #8 Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа 
// от 1 до N.
//====================================================

//ввод данных пользователем и null safety
string inputLineN = Console.ReadLine() ?? "";

//преобразуем строку в число и вводим переменную счётчик начиная с 2, тк это первое чётное число после 1 по условию
int counter = 2;

if (inputNumberN >= 2) //если введённое число больше или равно 2 (тк это первое чётное число после 1)
{
    while (counter <= inputNumberN) // пока счётчик больше (или равен) введённого числа
    {
        Console.Write(counter + " "); //вывожим число на экран в строку
        counter = counter + 2; //прибавляем к счётчику 2, тк нас интересуют лишь чётные числа
    }
}
else //иначе пользователю нужно ввести другую цифру
{
    Console.WriteLine("В диапазоне от 1 до " + inputNumberN + " нет положительных чётных чисел. Попробуйте снова.");
}