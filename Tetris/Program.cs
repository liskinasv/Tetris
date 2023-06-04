// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using Tetris;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40, 30);


FigureGenerator generator = new FigureGenerator(20, 0, '*');
Figure currentFigure = generator.GetNewFigure();

while (true)
{
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey();
        HandleKey(currentFigure, key);
    }
}

void HandleKey(Figure figure, ConsoleKeyInfo key)
{
    switch(key.Key)
    {
        case ConsoleKey.LeftArrow:
            figure.Move(Direction.Left); 
            break;
        case ConsoleKey.RightArrow: 
            figure.Move(Direction.Right); 
            break;
        case ConsoleKey.DownArrow: 
            figure.Move(Direction.Down); 
            break;
    }
}


