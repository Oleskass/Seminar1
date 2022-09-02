//====================================================
// Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
//====================================================

//Console.Clear();

Console.Write("Помогу узнать максимум из трёх чисел!:) \nВведите первое число: ");
string inputLineA = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string inputLineB = Console.ReadLine() ?? "";
Console.Write("Введите третье число: ");
string inputLineC = Console.ReadLine() ?? "";

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);
int inputNumberC = int.Parse(inputLineC);
int maxNumber;

if (inputNumberA > inputNumberB)
{
    maxNumber = inputNumberA;
}
else
{
    maxNumber = inputNumberB;
}

if (inputNumberC > maxNumber)
{
    maxNumber = inputNumberC;
}

Console.WriteLine("Max = " + maxNumber);