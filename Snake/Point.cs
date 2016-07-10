using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    public class Point
    {
        public const int WIDTH = 16;
        public const int HEIGHT = 16;

        private int mX;
        private int mY;

        public Point(int x, int y)
        {
            this.mX = x;
            this.mY = y;
        }

        public void setX(int x)
        {
            this.mX = x;
        }

        public void setY(int y)
        {
            this.mY = y;
        }

        public int getX()
        {
            return this.mX;
        }

        public int getY()
        {
            return this.mY;
        }

        public void incX()
        {
            this.mX++;
        }

        public void incY()
        {
            this.mY++;
        }

        public void decX()
        {
            this.mX--;
        }

        public void decY()
        {
            this.mY--;
        }
    }   
}