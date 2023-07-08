string PrintNums(int N)
{
    if (N == 1) return "1";
    else return (N + " " + PrintNums(N - 1));
}

int inputNum(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int N = inputNum("Введите целое число");
string numsToPrint = PrintNums(N);
Console.WriteLine(numsToPrint);

