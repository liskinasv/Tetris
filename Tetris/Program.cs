// See https://aka.ms/new-console-template for more information
using Tetris;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40, 30);


FigureGenerator generator = new FigureGenerator(20, 0, '*');
Figure s = null;

for (int i = 0; i < 20; i++)
{
    FigureFall(generator, out s);
    s.Draw();
}
Console.ReadLine();


static void FigureFall(FigureGenerator generator, out Figure f)
{
    f = generator.GetNewFigure();

    f.Draw();

    for (int j = 0; j < 20; j++)
    {
        f.Hide();
        f.Move(Direction.Down);
        f.Draw();

        Thread.Sleep(200);
    }
}

