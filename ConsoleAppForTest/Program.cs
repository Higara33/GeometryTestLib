using GeometryTestLib;
using GeometryTestLib.Figures;

Figure figure = new Triangle(1, 3, 3);

var test = figure.GetSquare();
Console.WriteLine(test);

Figure figure1 = new Circle(4);
var test1 = figure1.GetSquare();
Console.WriteLine(test1);
