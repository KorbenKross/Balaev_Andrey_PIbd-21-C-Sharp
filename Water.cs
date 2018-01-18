using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
	class Water
	{
		private int temperature = 0;
		public int Temperature { get { return temperature; } }
		public void GetStew() {
			if (temperature < 100)
			{
				temperature++;
			}
		}
	}
}
