using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Vehicle : ITransport
    {

        protected float startPosX;
        protected float startPosY;

        protected int countPassengers;

        public virtual int MaxCountPassengers { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }

        public Color ColorBody { protected set; get; }

        public virtual double Weight { protected set; get; }

        public abstract void drawLocomotive(Graphics g);


        public abstract void moveLocomotive(Graphics g);
      

        public int getPassenger()
        {
            int count = countPassengers;
            countPassengers = 0;
            return count;
        }

        public void loadPassengers(int count)
        {
            if (countPassengers + count < MaxCountPassengers)
            {
                countPassengers += count;
            }
        }


        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public virtual void setMainColor(Color color)
        {
            ColorBody = color;
        }
        public abstract string getInfo();
    }
}
