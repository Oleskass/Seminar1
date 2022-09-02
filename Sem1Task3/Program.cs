//====================================================
// #3 Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// Например:
// 3 -> Среда
// 5 -> Пятница
//====================================================

string inputLine = Console.ReadLine()??"";

    int inputDayOfWeek = int.Parse(inputLine);

    string[] dayOfWeek = new string[7]; //массив
    dayOfWeek[0] = "Monday";
    dayOfWeek[1] = "Tuesday";
    dayOfWeek[2] = "Wednesday";
    dayOfWeek[3] = "Thursday";
    dayOfWeek[4] = "Friday";
    dayOfWeek[5] = "Saturday";
    dayOfWeek[6] = "Sunday";

    if (inputDayOfWeek > 7 || inputDayOfWeek < 1) //или
    {
        Console.WriteLine("There is no such day of the week");
    }
    else
    {
        Console.WriteLine(dayOfWeek[inputDayOfWeek - 1]);
    }


    // string outDayOfWeek = string.Empty; // string outDayOfWeek = "";
    // switch (inputDayOfWeek)
    // {
    //  case 1: outDayOfWeek = "Monday"; break;
    //  case 2: outDayOfWeek = "Tuesday"; break;
    //  case 3: outDayOfWeek = "Wednesday"; break;
    //  case 4: outDayOfWeek = "Thursday"; break;
    //  case 5: outDayOfWeek = "Friday"; break;
    //  case 6: outDayOfWeek = "Saturday"; break;
    //  case 7: outDayOfWeek = "Sunday"; break;
    //  default: outDayOfWeek = "It's not a day of the week."; break;
    // }
    // Console.WriteLine(outDayOfWeek);