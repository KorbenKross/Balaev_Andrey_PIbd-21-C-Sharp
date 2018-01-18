using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
	class Knife
	{
		public void Clean_potato(Potato p) {
			if (p.Have_skin) 
			{
				p.Have_skin = false;
			}
		}
        public void Clean_carrot(Carrot c)
        {
            if (c.Have_skin)
            {
                c.Have_skin = false;
            }
        }

    }
}
