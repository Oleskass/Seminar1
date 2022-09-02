//====================================================
// #1 Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.
// Например:
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет
//====================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    bool outResult = (inputNumberA == inputNumberB * inputNumberB);

    //bool outResult = (inputNumberB == inputNumberA / inputNumberB);
    //bool outResult = (Math.Sqrt(inputNumberA) == inputNumberB);
    //bool outResult = (inputNumberA == (int)Math.Pow(inputNumberB,2));

    Console.WriteLine(outResult);
}

// string inputLineA = Console.ReadLine()??"";
// string inputLineB = Console.ReadLine()??"";

//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     bool outResult = (inputNumberA == inputNumberB * inputNumberB);

//     //bool outResult = (inputNumberB == inputNumberA / inputNumberB);
//     //bool outResult = (Math.Sqrt(inputNumberA) == inputNumberB);
//     //bool outResult = (inputNumberA == (int)Math.Pow(inputNumberB,2));

//     Console.WriteLine(outResult);