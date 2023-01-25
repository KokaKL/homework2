// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int InputInt(string message)
{
    System.Console.WriteLine(message + " >");
    string number = Console.ReadLine();
    int result = Convert.ToInt32(number);
    return result;
}
int calculate(int number)
{
    if (number > 1000)
    {
        while (number > 1000)
        {
           number = number / 10;
        }
    }
        number = number % 10;
        return number;
}

int num = InputInt("Введите число");
if (num < 99)
{
    System.Console.WriteLine("Error");
}
else
{
System.Console.WriteLine(calculate(num));
}