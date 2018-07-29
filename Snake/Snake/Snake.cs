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

        public void Move()
        {
            Point tall = pList.First();
            pList.Remove(tall);
            Point head = GetNextPoint();
            pList.Add(head);

            tall.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        //Methood, change snake direction + protection of reversing
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.RIGHT)
                {
                    direction = Direction.LEFT;
                }
            }
            else if (key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.LEFT)
                {
                    direction = Direction.RIGHT;
                }
            } 
            else if (key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.DOWN)
                {
                    direction = Direction.UP;
                }
            }
            else if (key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.UP)
                {
                    direction = Direction.DOWN;
                }
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            { return false; }
        }
    }
}
