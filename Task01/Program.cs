// Задача 10

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);
    return number;
}
int number = ReadInt("Введите трёхзначное число");
if (number < 1000 && number >99)
{
    int MidleDigital = number / 10 % 10;
    Console.WriteLine("MidleDigital = " + MidleDigital);
    }
    else Console.WriteLine("Число не трёхзначное");