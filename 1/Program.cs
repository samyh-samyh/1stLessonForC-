Console.Clear();
Console.Write("Inter any number: ");
int number=int.Parse(Console.ReadLine());
int sqr=number*number;
Console.WriteLine($"Number square= {sqr} for {number}");

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} равен {sqr1}");
double number2 = 3.3;
double sqr2=(Math.Pow(number2, 2));
Console.WriteLine($"Квадрат числа {number2} равен {Math.Round(sqr2, 2)}");
