using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CartLocomotive : Locomotive
    {
        private bool anthen;
        private bool roof;
        private bool lightEngine;
        private Color dopColor;

        public CartLocomotive(int maxSpeed, int maxCountPassengers, double weight, Color color, bool anthen, bool roof, bool lightEngine, Color dopColor) : base(maxSpeed, maxCountPassengers, weight, color)
        {
            this.anthen = anthen;
            this.roof = roof;
            this.lightEngine = lightEngine;
            this.dopColor = dopColor;
        }

        protected override void drawBaseLocomotive(Graphics g)
        {
            if (anthen)
            {
                Pen penB = new Pen(Color.Black);

                Brush Coal = new SolidBrush(dopColor);
                g.DrawLine(penB, startPosX, startPosY - 30, startPosX + 30, startPosY - 30);
                g.DrawLine(penB, startPosX, startPosY - 30, startPosX + 20, startPosY);
                g.DrawLine(penB, startPosX + 30, startPosY - 30, startPosX + 20, startPosY);

                g.DrawLine(penB, startPosX + 50, startPosY - 30, startPosX + 80, startPosY - 30);
                g.DrawLine(penB, startPosX + 50, startPosY - 30, startPosX + 70, startPosY);
                g.DrawLine(penB, startPosX + 80, startPosY - 30, startPosX + 70, startPosY);
            }



            if (roof)
            {
                Pen penB = new Pen(Color.Black);
                Brush Coal = new SolidBrush(dopColor);
                g.DrawRectangle(penB, startPosX + 10, startPosY + 10, 80, 10);
                g.FillRectangle(Coal, startPosX + 10, startPosY + 30, 80, 10);

            }
            if (lightEngine)
            {
                Pen penB = new Pen(Color.Black);
                Brush Coal = new SolidBrush(Color.Green);
                g.DrawRectangle(penB, startPosX + 10, startPosY - 5, 70, 10);
                g.FillRectangle(Coal, startPosX + 10, startPosY - 5, 70, 10);

            }
            base.drawBaseLocomotive(g);          

        }

        public void setDopColor(Color color)
        {
            dopColor = color;
        }


    }
}
