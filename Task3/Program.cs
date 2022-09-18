using ClassLibrary1;

Point p1 = new Point (0 ,0);
Point p2 = new Point (4 ,0);
Point p3 = new Point(4, 4);
Point p4 = new Point (0 ,4);

Figura fig = new Figura(p1, p2, p3, p4);
Console.WriteLine(fig.Perimetr);

