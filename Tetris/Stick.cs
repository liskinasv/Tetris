using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Stick : Figure
    {
        public Stick(int x, int y, char sym) 
        {
            points[0] = new Point(x, y, sym);
            points[1] = new Point(x, y + 1, sym);
            points[2] = new Point(x, y + 2, sym);
            points[3] = new Point(x, y + 3, sym);

            Draw();
        }

  
        public override void Rotate(Point[] pArray)
        {
            if (pArray[0].X == pArray[1].X)
            {
                RotateHorizontal(pArray);
            }
            else
            {
                RotateVertical(pArray);
            }
        }

        private void RotateHorizontal(Point[] pArray)
        {
            for (int i = 0; i < points.Length; i++) 
            {
                pArray[i].Y = pArray[0].Y;
                pArray[i].X = pArray[0].X + i;
            }
        }

        private void RotateVertical(Point[] pArray)
        {
            for (int i = 0; i < points.Length; i++)
            {
                pArray[i].X = pArray[0].X;
                pArray[i].Y = pArray[0].Y + i;
            }
        }
    }
}
