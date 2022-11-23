float factorial(int n)
{
  float i, x = 1;
  for (i = 1; i <= n; i++)
  {
    x *= i;
  }
  return x;
}
int i, j,N;
void Results(int N)
{
  Console.Clear();
  for (i = 0; i < N; i++)
  {
    for (j = 0; j <= (N - i); j++)
    {
      Console.Write(" ");
    }
    for (j = 0; j <= i; j++)
    {
      Console.Write(" ");
      Console.Write(Math.Round(factorial(i) / (factorial(j) * factorial(i - j))));
    }
    Console.WriteLine();
  }
  Console.ReadKey();
}

Console.WriteLine("Введите нужное количество строк ");
N= Convert.ToInt32(Console.ReadLine());
Results(N);
/* красота дело относительное. Формально треугольник равнобедеренный но отображается не слишком корректно как только
появляются числа больше чем 1 символ. Так же понятно, что с какого то момента пойдет переполнение
(конкретно с 35 строчки в моем примере) и перестанет корректно работать. проверка на это в задание не входило.
красиво попытался делать через Console.SetCursorPosition с последующим
(Console.WindowWidth / 2) - (tmpStringRow.Length / 2),однако код получался перекруженным из за постоянного
перекидывания в string, float, char и т.д, собственно о красоте меня в задании и не просили*/
