Console.WriteLine("Введите первый катет");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второй катет");
double b = double.Parse(Console.ReadLine());
double c = Math.Sqrt(a*a +b*b);
double h = (a*b)/c;
Console.WriteLine(h);