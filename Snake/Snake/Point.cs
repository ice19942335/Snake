using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        //Поля класса
        public int x;
        public int y;
        public char sym;

        //Конструктор со значениями по умолчанию
        public Point(int x = 0, int y = 0, char sym = '?')
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        //Метод установки курсора в консоли и вывода символа
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    }
}
