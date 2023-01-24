// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки для расчета.

int InputInt(string message)
{
    System.Console.WriteLine(message + " >");
    string num = Console.ReadLine();
    int result = Convert.ToInt32(num);
    return result;
}

bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)
    {
        int secondRank = number / 10 % 10;
        System.Console.WriteLine($"Вторая цифра числа {number} равна {secondRank}");
        return true;
    }
    else
    {
        System.Console.WriteLine("Число не трехзначное");
        return false;
    }
}
int number = InputInt("Введите число");
if (ValidateNumberRank3(number));