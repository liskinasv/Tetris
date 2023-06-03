using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;

        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    x = x - 1;
                    break;
                case Direction.Right:
                    x = x + 1; 
                    break;
                case Direction.Down:
                    y = y + 1; 
                    break;

            }

        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
