using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum DIRECTION
    {
        DOWN,
        LEFT,
        RIGHT,
        UP,
        NONE
    }

    class Snake
    {
        public const int START_POINT_X = 10;
        public const int START_POINT_Y = 5;

        private List<Point> mPartList;
        private DIRECTION mDirection;

        public Snake()
        {
            this.mPartList = new List<Point>();
            this.mDirection = DIRECTION.DOWN;

            Point head = new Point(START_POINT_X, START_POINT_Y);
            this.mPartList.Add(head);
        }

        public void Update(Boolean isGrowing)
        {
            for (int i = this.mPartList.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (this.mDirection)
                    {
                        case DIRECTION.DOWN:
                            this.mPartList[i].incY();
                            break;

                        case DIRECTION.LEFT:
                            this.mPartList[i].decX();
                            break;

                        case DIRECTION.RIGHT:
                            this.mPartList[i].incX();
                            break;

                        case DIRECTION.UP:
                            this.mPartList[i].decY();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    this.mPartList[i].setX(this.mPartList[i - 1].getX());
                    this.mPartList[i].setY(this.mPartList[i - 1].getY());
                }
            }

            if (isGrowing)
            {
                this.mPartList.Add(new Point(this.mPartList[this.mPartList.Count - 1].getX(),
                    this.mPartList[this.mPartList.Count - 1].getY()));
            }
            /* Else do nothing */
        }

        public void setDirection(DIRECTION direction)
        {
            this.mDirection = direction;
        }

        public Boolean isBaby()
        {
            return this.mPartList.Count == 1;
        }

        public int getPartX(int partNumber)
        {
            return this.mPartList[partNumber].getX();
        }

        public int getPartY(int partNumber)
        {
            return this.mPartList[partNumber].getY();
        }

        public int getLength()
        {
            return this.mPartList.Count;
        }

        public Boolean isBitting()
        {
            Boolean isBitting = false;
            
            for(int i = 4; i < this.mPartList.Count; i++)
            {
                if(this.mPartList[i].getX().Equals(this.mPartList[0].getX()) &&
                    this.mPartList[i].getY().Equals(this.mPartList[0].getY()))
                {
                    isBitting = true;
                    break;
                }
            }

            return isBitting;
        }
    }
}
