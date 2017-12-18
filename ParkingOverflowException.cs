using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() :
            base("В депо нет свободных мест!")
        { }
    }
}
