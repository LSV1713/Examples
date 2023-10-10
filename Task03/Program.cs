// Задача 3

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number = ReadInt("Введите число");
if (number == 6 || number == 7)
{
    Console.WriteLine("да");
}
    else Console.WriteLine("нет");