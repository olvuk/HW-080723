int inputNum(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetAck(int N, int M)
{
   if (N == 0) return M + 1;
   else if (M == 0) return GetAck(N - 1, 1);
   else return GetAck(N - 1, GetAck(N, M - 1));
}

int N = inputNum("Введите первое целое число");
int M = inputNum("Введите второе целое число");

int result = GetAck(N, M);
Console.WriteLine(result);