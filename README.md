# Shapes. Подсчет полащадей геометрических фигур.

1. Shapes.Abstractions - библиотека с абстракциями.
2. Shapes - основная библиотека с релизациями абстракций из Shapes.Abstractions.
3. Shapes.Extensions - библиотека с методами расширения для фигур.

Пример подсчета площади круга.

```csharp
var radius = 1.0d;
var circle = new Circle(radius);

var area = circle.GetArea();
```

