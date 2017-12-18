using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CartLocomotive : Locomotive, IComparable<CartLocomotive>, IEquatable<CartLocomotive>
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


        public CartLocomotive(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8) {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                anthen = Convert.ToBoolean(strs[4]);
                roof = Convert.ToBoolean(strs[5]);
                lightEngine = Convert.ToBoolean(strs[6]);
                dopColor = Color.FromName(strs[7]);
            }
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

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name + ";" + anthen + ";" + roof + ";" + lightEngine + ";" + dopColor.Name;
        }

        public int CompareTo(CartLocomotive other)
        {
            var res = (this is Vehicle).CompareTo(other is Vehicle);
            if (res != 0)
            {
                return res;
            }
            if (anthen != other.anthen)
            {
                return anthen.CompareTo(other.anthen);
            }
            if (lightEngine != other.lightEngine)
            {
                return lightEngine.CompareTo(other.lightEngine);
            }
            if (roof != other.roof)
            {
                return roof.CompareTo(other.roof);
            }
            if (dopColor != other.dopColor)
            {
                return dopColor.Name.CompareTo(other.dopColor);
            }
            return 0;
        }
        public bool Equals(CartLocomotive other)
        {
            var res = (this is Vehicle).Equals(other is Vehicle);
            if (!res)
            {
                return res;
            }
            if (anthen != other.anthen)
            {
                return false;
            }
            if (lightEngine != other.lightEngine)
            {
                return false;
            }
            if (roof != other.roof)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }

            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            CartLocomotive carObj = obj as CartLocomotive;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
