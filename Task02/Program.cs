// Задача 2

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number = ReadInt("Введите число");
if (number < 99)
{
    Console.WriteLine("третьей цифры нет");
}
    else 
    {
        while (number > 999)
        {
            number /= 10 ;
        }

        int TreeDigital = number % 10;
        Console.WriteLine(TreeDigital);
    }