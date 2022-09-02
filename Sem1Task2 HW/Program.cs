//====================================================
// #2 Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3
//====================================================

Console.Clear();

Console.Write("Помогу узнать максимум и минимум из двух чисел!:) \nВведите первое число: ");
string inputLineA = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string inputLineB = Console.ReadLine() ?? "";

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);

if (inputNumberA > inputNumberB)
{
    Console.WriteLine("Max = " + inputNumberA + ", min = " + inputNumberB);
}
else
{
    Console.WriteLine("Max = " + inputNumberB + ", min = " + inputNumberA);
}