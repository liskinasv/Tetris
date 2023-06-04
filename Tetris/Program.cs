// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using Tetris;


Field.Width = 40;
Field.Height = 30;

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
            figure.TryMove(Direction.LEFT); 
            break;
        case ConsoleKey.RightArrow: 
            figure.TryMove(Direction.RIGHT); 
            break;
        case ConsoleKey.DownArrow: 
            figure.TryMove(Direction.DOWN); 
            break;
        case ConsoleKey.Spacebar:
            figure.TryRotate();
            break;
    }
}




