using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9
{
    class Depo
    {
        ClassArray<ITtransport> depo;
        int countPlaces = 10;
        int placceSizeWidth = 210;
        int placeSizeHeight = 80;

        public Depo(){
            depo = new ClassArray<ITtransport>(countPlaces, null);
        }
        public int PutCarInParking(ITtransport train) {
            return depo + train;
        }
        public ITtransport GetCarInParking(int statement) {
            return depo - statement;
        }

        public void Draw(Graphics g, int width, int height) {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++) {
                var train = depo.getObject(i);
                if (train != null) {
                    train.setPosition(5 + i / 5 * placceSizeWidth + 5, i % 5 * placeSizeHeight + 30);
                    train.drawCar(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placceSizeWidth, 480);
            for (int i = 0; i < countPlaces; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placceSizeWidth, j * placeSizeHeight, i * placceSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placceSizeWidth, 0, i * placceSizeWidth, 400);
            }
        }
    }
}
