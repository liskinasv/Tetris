using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym { get; set; }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;

        }

        public Point(Point point): this (point.X, point.Y, point.Sym) { }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
            Console.SetCursorPosition(0, 0);
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    X = X - 1;
                    break;
                case Direction.RIGHT:
                    X = X + 1; 
                    break;
                case Direction.DOWN:
                    Y = Y + 1; 
                    break;

            }

        }

        internal void Hide()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(" ");
        }
    }
}
