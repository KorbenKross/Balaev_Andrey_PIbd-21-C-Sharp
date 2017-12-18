using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ITransport
    {
        void moveLocomotive(Graphics g);

        void drawLocomotive(Graphics g);

        void setPosition(int x , int y);

        void loadPassengers(int count);   

        int getPassenger();

        void setMainColor(Color color);

        string getInfo();
    }
}
