using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
	class Oven
	{
		private Pan pan;
		public bool State { set; get; }
		public Pan Pan {set {pan = value;} get {return pan;}}
		public void Cook() {
			if (State) {
				while (!pan.IsReady()) {
					pan.GetStew();
				}
			}
		}
	}
}
