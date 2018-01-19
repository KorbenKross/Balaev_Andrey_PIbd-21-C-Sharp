using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
	class PasTrain : Train
	{
		private bool lightEngine;
		private bool anthen;
		private bool roof;

		private Color dopColor;

		public PasTrain(int maxSpeed, int maxCountPassenger, int maxCapacityGenerator, double weight, Color color, bool lightEngine, bool anthen, bool roof, Color dopColor) : base(maxSpeed, maxCountPassenger, maxCapacityGenerator,weight, color)
		{
			this.lightEngine = lightEngine;
			this.anthen = anthen;
			this.roof = roof;
			this.dopColor = dopColor;
		}

		protected override void drawLoc(Graphics g) {
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
            base.drawLoc(g);

		}
	}
}
