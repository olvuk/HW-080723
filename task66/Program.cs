int findSum(int M, int N)
{
    if (N == M) return N;
    else return findSum(M, N - 1) + N;
}


int inputNum(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int M = inputNum("Введите первое целое число");
int N = inputNum("Введите второе целое число");


int sum = findSum(M, N);
Console.WriteLine(sum);
