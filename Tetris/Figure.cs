using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    abstract class Figure
    {
        const int LENGTH = 4;
        protected Point[] points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }

        public void Move(Point[] pArray, Direction dir)
        {
            foreach(var p in pArray) 
            {
                p.Move(dir);
            }
        }

        public void TryMove(Direction dir)
        {
            Hide();

            var clone = Clone();
            Move(clone, dir);

            if(VerifyPosition(clone))
            {
                points = clone;
            }

            Draw();
        }

        public bool VerifyPosition(Point[] pArray)
        {
            foreach (Point p in pArray)
            {
                if ((p.X < 0) || (p.Y < 0) || 
                    (p.X >= Field.Width) || (p.Y >= Field.Height))
                {
                    return false;
                }
               
            }
            return true;
        }

        public Point[] Clone() 
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; i++)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }


        public void Hide()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }

        abstract public void Rotate(Point[] pArray);

        public void TryRotate()
        {
              Hide();

            var clone = Clone();
            Rotate(clone);

            if (VerifyPosition(clone))
            {
                points = clone;
            }

            Draw();
        }

    }
}
