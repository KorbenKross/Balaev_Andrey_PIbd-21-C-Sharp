using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
	public class Train : Locomotive
	{
		public override int MaxSpeed
		{
			get
			{
				return base.MaxSpeed;
			}

			protected set
			{
				if (value > 0 && value < 200)
				{
					base.MaxSpeed = value;
				} else
				{
					base.MaxSpeed = 150;
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
				if (value > 800 && value < 1300)
				{
					base.Weight = value;
				}
				else
				{
					base.Weight = 1000;
				}
			}
		}

		public Train(int maxSpeed, int maxCountPassenger,int maxCapacityGenerator, double weight, Color color)
		{
			this.MaxSpeed = maxSpeed;
			this.MaxCountPassengers = maxCountPassenger;
            this.MaxCapacityGenerator = maxCapacityGenerator;
            this.ColorBody = color;
			this.Weight = weight;
			this.countPassengers = 0;
			Random rand = new Random();
			startPosX = rand.Next(10, 200);
			startPosY = rand.Next(10, 200);
		}
		public override void drawCar(Graphics g)
		{
			drawLoc(g);
		}

		protected virtual void drawLoc(Graphics g)
		{
            Pen penB = new Pen(Color.Blue);
            Pen penR = new Pen(Color.Red);
            Brush brushR = new SolidBrush(Color.Red);
            Brush brushB = new SolidBrush(Color.Blue);
            Brush brushRB = new SolidBrush(Color.Gray);

            //g.DrawEllipse(penR, startPosX + 10, startPosY + 30, 20, 20);
            //g.DrawEllipse(penR, startPosX + 25, startPosY + 30, 20, 20);
            ////g.DrawEllipse(penR, startPosX + 60, startPosY + 30, 20, 20);
            ////g.DrawEllipse(penR, startPosX + 75, startPosY + 30, 20, 20);



            g.FillEllipse(brushRB, startPosX + 10, startPosY + 30, 20, 20);
            //g.FillEllipse(brushRB, startPosX + 25, startPosY + 30, 20, 20);
            //g.FillEllipse(brushRB, startPosX + 60, startPosY + 30, 20, 20);
            g.FillEllipse(brushRB, startPosX + 75, startPosY + 30, 20, 20);


            Brush LokoBrush = new SolidBrush(ColorBody);
            g.FillRectangle(LokoBrush, startPosX, startPosY, 100, 30);


            //g.DrawRectangle(penB, startPosX + 100, startPosY + 20, 5, 5);
            g.DrawRectangle(penB, startPosX + 85, startPosY + 5, 20, 20);
            g.DrawRectangle(penB, startPosX + 65, startPosY + 5, 10, 20);
            g.DrawLine(penB, startPosX + 100, startPosY , startPosX+105, startPosY + 5);
            g.DrawLine(penB, startPosX + 10, startPosY + 40, startPosX + 30, startPosY + 40);
            g.DrawLine(penB, startPosX + 75, startPosY + 40, startPosX + 95, startPosY + 40);
            g.DrawLine(penB, startPosX - 5, startPosY + 20, startPosX, startPosY + 20);
            g.DrawLine(penB, startPosX - 5, startPosY + 10, startPosX - 5, startPosY + 25);
            g.DrawLine(penB, startPosX, startPosY + 10, startPosX + 10, startPosY );
            g.DrawLine(penB, startPosX, startPosY + 25, startPosX + 100, startPosY + 25);
        }

		public override void moveCar(Graphics g)
		{
			startPosX += (MaxSpeed * 50 / (float)Weight) / (countPassengers == 0 ? 1 : countPassengers);
			drawCar(g);
		}
	}
}
