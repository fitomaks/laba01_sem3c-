using ClassLibrary1;

Console.WriteLine("введите стороны прямоугольника");

double a = Convert.ToDouble( Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

Rectangle rec = new Rectangle(a, b);

Console.WriteLine($"Perimetr {rec.Perimeter}");
Console.WriteLine($"Ploshad {rec.Area}");

