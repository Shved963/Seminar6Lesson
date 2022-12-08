// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Clear();

//Тело программы

int number = IntoInt();

Console.WriteLine($"{number} -> {GetBinNumber(number)}");

//Методы
string GetBinNumber(int num)
{
    string binar = string.Empty;

    while (num != 0)
    {
        binar = num%2 + binar;
        num/=2;
    }
    
    return binar;
}


int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed || num < 1)
    {
        Console.WriteLine("Incorrect number");
        return -1;
    }
    else
    {
        return num;
    }
}