using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Locomotive : Vehicle
    {

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 150)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 50;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 0 && value < 0)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 4;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {

                if (value > 300 && value < 1000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 1000;
                }
            }
        }

        public Locomotive(int maxSpeed, int maxCountPassengers, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(400, 500);
            startPosY = rand.Next(100, 200);
        }


        public override void drawLocomotive(Graphics g)
        {
            drawBaseLocomotive(g);
        }

        public override void moveLocomotive(Graphics g)
        {
            startPosX -= (MaxSpeed *50/(float)Weight)/(countPassengers==0?1:countPassengers);
            drawLocomotive(g);
        }

        protected virtual void drawBaseLocomotive(Graphics g)
        {

            Pen penB = new Pen(Color.Blue);
            Pen penR = new Pen(Color.Red);
            Brush brushR = new SolidBrush(Color.Red);
            Brush brushB = new SolidBrush(Color.Blue);
            Brush brushRB = new SolidBrush(Color.Gray);

            g.FillEllipse(brushRB, startPosX + 10, startPosY + 30, 20, 20);
            g.FillEllipse(brushRB, startPosX + 75, startPosY + 30, 20, 20);


            Brush LokoBrush = new SolidBrush(ColorBody);
            g.FillRectangle(LokoBrush, startPosX, startPosY, 100, 30);

            g.DrawRectangle(penB, startPosX + 85, startPosY + 5, 20, 20);
            g.DrawRectangle(penB, startPosX + 65, startPosY + 5, 10, 20);
            g.DrawLine(penB, startPosX + 100, startPosY, startPosX + 105, startPosY + 5);
            g.DrawLine(penB, startPosX + 10, startPosY + 40, startPosX + 30, startPosY + 40);
            g.DrawLine(penB, startPosX + 75, startPosY + 40, startPosX + 95, startPosY + 40);
            g.DrawLine(penB, startPosX - 5, startPosY + 20, startPosX, startPosY + 20);
            g.DrawLine(penB, startPosX - 5, startPosY + 10, startPosX - 5, startPosY + 25);
            g.DrawLine(penB, startPosX, startPosY + 10, startPosX + 10, startPosY);
            g.DrawLine(penB, startPosX, startPosY + 25, startPosX + 100, startPosY + 25);
        }

    }
}
