using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Blender
    {
        public bool State { get; set; }
        public void Cut_potato(Potato p)
        {
            if (p.Have_cut)
            {
                p.Have_cut = false;
            }
        }
        public void Cut_carrot(Carrot c)
        {           
            if (c.Have_cut)
            {
                c.Have_cut = false;
            }
        }
        public void Cut_bow(Bow b)
        {           
            if (b.Have_cut)
            {
                b.Have_cut = false;
            }
        }
        public void Cut_zucchini(Zucchini z)
        {
            if (z.Have_cut)
            {
                z.Have_cut = false;
            }
        }
        public void Cut_tomato(Tomato t)
        {
            if (t.Have_cut)
            {
                t.Have_cut = false;
            }
        }

        public Blender GetWater()
        {
            if (State)
            {
                return new Blender();
            }
            else
            {
                return null;
            }
        }
    }
}
