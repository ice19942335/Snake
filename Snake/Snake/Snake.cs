using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tall, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tall);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tall = pList.First();
            pList.Remove(tall);
            Point head = GetMaxPoint();

            tall.Clear();
            head.Draw();
        }

        public Point GetMaxPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
