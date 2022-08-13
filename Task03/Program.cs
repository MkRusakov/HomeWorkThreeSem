// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void numbers(int N)
{
    for (int i = 1;i<=N;i++) 
    {
        double result = Math.Pow(i,3);
        Console.WriteLine(result);
    }
}
numbers(5);
