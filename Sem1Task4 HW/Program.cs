//====================================================
// #4 Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22
//====================================================

//очистка окна терминала при запуске программы
//Console.Clear(); 

//ввод данных пользователем и null safety
Console.Write("Помогу узнать максимум из трёх чисел!:) \nВведите первое число: ");
string inputLineA = Console.ReadLine() ?? "";
Console.Write("Введите второе число: ");
string inputLineB = Console.ReadLine() ?? "";
Console.Write("Введите третье число: ");
string inputLineC = Console.ReadLine() ?? "";

//преобразуем строку в число
int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);
int inputNumberC = int.Parse(inputLineC);

//вводим переменную, которая будет хранить макс.значение
int maxNumber;

if (inputNumberA > inputNumberB)
{
    maxNumber = inputNumberA; //если А больше В, то присваиваем максимум числу А
}
else
{
    maxNumber = inputNumberB; //иначе максимум числу В
}

if (inputNumberC > maxNumber) //сравниваем максимум из предыдущей пары с 3 числом
{
    maxNumber = inputNumberC; //если С больше, то оно становится максимумом, если нет, то остаётся максимум одно из первой пары
}

Console.WriteLine("Max = " + maxNumber); //вывод максимального числа

//// Вариант, как нам показывали на семинаре

// if (inputNumberA > inputNumberB)
// {
//     if (inputNumberA > inputNumberC)
//     {
//         Console.WriteLine("Max = " + inputNumberA);
//     }
//     else
//     {
//         Console.WriteLine("Max = " + inputNumberC);
//     }
// }
// else
// {
//     if (inputNumberB > inputNumberC)
//     {
//         Console.WriteLine("Max = " + inputNumberB);
//     }
//     else
//     {
//         Console.WriteLine("Max = " + inputNumberC);
//     }
// }

//// С использованием метода Math.Max - мне понравилось больше всего :)

// int maxNum = Math.Max(inputNumberA, Math.Max(inputNumberB, inputNumberC));
// Console.WriteLine("Max = " + maxNum);


//// С использованием тернарного оператора

// int Max1 = (inputNumberA > inputNumberB) ? inputNumberA : inputNumberB;
// int Max2 = (Max1 > inputNumberC) ? Max1 : inputNumberC;

// Console.WriteLine("Max = " + Max2);