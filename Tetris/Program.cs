// See https://aka.ms/new-console-template for more information
using Tetris;

Console.SetWindowSize(40, 30);
Console.SetBufferSize(40, 30);


Figure[] figures = new Figure[2];
figures[0] = new Squery(1, 3, '*');
figures[1] = new Stick(10, 3, '#');



Thread.Sleep(500);
figures[0].Draw();

figures[0].Hide();
figures[0].Move(Direction.Down);
figures[0].Draw();

Thread.Sleep(500);

figures[0].Hide();
figures[0].Move(Direction.Right);
figures[0].Draw();

Thread.Sleep(500);

figures[0].Hide();
figures[0].Move(Direction.Right);
figures[0].Draw();

Thread.Sleep(500);

figures[0].Hide();
figures[0].Move(Direction.Down);
figures[0].Draw();

Thread.Sleep(500);

figures[1].Hide();
figures[1].Move(Direction.Down);
figures[1].Draw();
Thread.Sleep(500);

figures[1].Hide();
figures[1].Move(Direction.Right);
figures[1].Draw();
Thread.Sleep(500);

figures[1].Hide();
figures[1].Move(Direction.Right);
figures[1].Draw();
Thread.Sleep(500);

figures[1].Hide();
figures[1].Move(Direction.Right);
figures[1].Draw();
Thread.Sleep(500);

figures[1].Hide();
figures[1].Move(Direction.Right);
figures[1].Draw();
Thread.Sleep(500);

Console.ReadLine();

