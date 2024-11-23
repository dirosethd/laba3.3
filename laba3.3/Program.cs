Console.WriteLine("Введите значение x:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите количество членов ряда:");
int n = Convert.ToInt32(Console.ReadLine());

double result = CalculateTaylorSeries(x, n);

Console.WriteLine($"Результат ряда Тейлора для sin(x) при x = {x} и {n} членах: {result}");
    

   double CalculateTaylorSeries(double x, int n)
{
    double sum = 0;

    for (int i = 0; i < n; i++)
    {
        double term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
        sum += term;
    }

    return sum;
}

 double Factorial(int number)
{
    if (number == 0 || number == 1)
        return 1;

    double factorial = 1;
    for (int i = 2; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}