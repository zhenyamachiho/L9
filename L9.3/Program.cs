int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }

    }

    return result;
}

int Akk(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akk(m - 1, 1);
    else
        return Akk(m - 1, Akk(m, n - 1));
}

int m = GetNumber("m:");
int n = GetNumber("n:");

Console.WriteLine(Akk(m, n));