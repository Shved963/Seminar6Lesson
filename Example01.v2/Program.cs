// Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника:
// каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

Console.WriteLine("Введите 3 числа");

int AB = IntoInt();
int AC = IntoInt();
int BC = IntoInt();

if (AB == 0 && AC == 0 && BC == 0)
{
    Console.WriteLine("Incorrect number");
    return;
}

bool result = VerificationOfTriangleInequalityTheorem(AB, AC, BC);

Console.WriteLine(result);

bool VerificationOfTriangleInequalityTheorem(int ab, int ac, int bc)
{
    if (ab < (ac + bc) && ac < (ab + bc) && bc< (ac + ab))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed || num < 1)
    {
        return 0;
    }
    else
    {
        return num;
    }
}