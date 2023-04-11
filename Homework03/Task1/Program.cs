using Task1.Domain.Database;
using Task1.Domain.Methods;

Circle circle = new Circle { Id = 1, Radius = 7 };
Rectangle rectangle = new Rectangle { Id = 2, SideA = 4, SideB = 5 };

circle.PrintCircleInfo();
rectangle.PrintRectangleInfo();


DataBase<Circle> firstCircle = new DataBase<Circle>();
firstCircle.Add(circle);

DataBase<Rectangle> firstRectangle = new DataBase<Rectangle>();
firstRectangle.Add(rectangle);

firstCircle.PrintArea();
firstCircle.PrintPerimeter();

firstRectangle.PrintArea();
firstRectangle.PrintPerimeter();


