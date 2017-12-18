using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Vehicle : ITransport, IComparable<Vehicle>, IEquatable<Vehicle>
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

        public int CompareTo(Vehicle other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (MaxCountPassengers != other.MaxCountPassengers)
            {
                return MaxCountPassengers.CompareTo(other.MaxCountPassengers);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (ColorBody != other.ColorBody)
            {
                ColorBody.Name.CompareTo(other.ColorBody.Name);
            }

            return 0;
         }

        public bool Equals(Vehicle other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (MaxCountPassengers != other.MaxCountPassengers)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (ColorBody != other.ColorBody)
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
            Vehicle carObj = obj as Vehicle;
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
            return MaxSpeed.GetHashCode();
        }
    }
}
