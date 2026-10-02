using System.Diagnostics;
using System.Globalization;

string fio = "Окишев Максим Сергеевич";
string group = "ИСП-242";
DateTime date = DateTime.Now;
int number = Convert.ToInt32(Console.ReadLine());
string text = number switch
{
    1 => $"ФИО: {fio}",
    2 => $"Группа: {group}",
    3 => $"Дата и время: {date}",
    _ => "Выход",
};

if (text == "Выход")
{
    Environment.Exit(0);
} else
{
    Console.WriteLine(text);
}