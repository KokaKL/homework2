// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayInput (string massage)
{
    System.Console.WriteLine(massage);
    string day = Console.ReadLine();
    int result = Convert.ToInt32(day);
    return result;
}

int dayOFweek(int days)
{
    if (days>0 && days<7 )
    {
        string[] arrayweek = new string[7] {"ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ", "ВС"};
        System.Console.WriteLine(arrayweek[days-1]);
    }
    else
    {
        System.Console.WriteLine("это не день недели");
    }
    return days;
} 

int inputday =dayInput("Введите номер дня недели");
int resultday = dayOFweek(inputday);
