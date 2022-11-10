// Написать функцию Sqrt(x) - квадратного корня, которая принимает на
// вход целочисленное значение x и возвращает целую часть квадратного
// корня от введенного числа.
// 4 -> 2
// 28 -> 5
// int IntPartSquareRoot(int num)
// {
//     int oddNum = 1;
//     int count = 0;
//     if (num == 0)
//     {
//         count = 0;
//     }
//     else
//     {
//         while (num >= oddNum)
//         {
//             num = num - oddNum;
//             oddNum = oddNum + 2;
//             count++;
//         }
//     }
//     return count;
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// int SqrRootX = IntPartSquareRoot(x);
// Console.WriteLine($"Целая часть квадратного корня равна: {SqrRootX}");
void IntPartSquareRoot(int num)
{
    int oddNum = 1;
    int count = 0;
    if (num == 0)
    {
        Console.WriteLine($"Целая часть квадратного корня равна: {count}");
    }
    else
    {
        while (num >= oddNum)
        {
            num = num - oddNum;
            oddNum = oddNum + 2;
            count++;
        }
        Console.WriteLine($"Целая часть квадратного корня равна: {count} и - {count}");
    }
    
}
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
IntPartSquareRoot(x);