using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	class Pan
	{
		private Water[] water;
		private Potato[] potatos;
		private Carrot[] carrots;
		private Tomato[] tomatoes;
		private Zucchini[] zucchinies;
		private Bow[] bows;
		private Cabbage[] cabbages;
		private Salt salt;
		private Spice spice;
		private tomato_paste paste;

        public bool ReadyToGo { get { return Check(); } }
		public void Init(int countPotatos, int countCarrot, int countBow, int countTomato, int countZucchini)
		{
			water = new Water[3];
			potatos = new Potato[countPotatos];
			carrots = new Carrot[countCarrot];
			bows = new Bow[countBow];
			tomatoes = new Tomato[countTomato];
			zucchinies = new Zucchini[countZucchini];
		}

		public void AddWater(Water w)
		{
			for (int i = 0; i < water.Length; ++i)
			{
				if (water[i] == null)
				{
					water[i] = w;
					return;
				}
			}

		}

		public void AddSalt(Salt s)
		{
			salt = s;
		}
		public void AddPaste(tomato_paste tp)
		{
			paste = tp;
		}
		public void AddSpice(Spice sp)
		{
			spice = sp;
		}
		public void AddPotato(Potato p)
		{
			for (int i = 0; i < potatos.Length; ++i)
			{
				if (potatos[i] == null)
				{
					potatos[i] = p;
					return;
				}
			}
		}
		public void AddCarrot(Carrot c)
		{
			for (int i = 0; i < carrots.Length; ++i)
			{
				if (carrots[i] == null)
				{
					carrots[i] = c;
					return;
				}
			}
		}
		public void AddBow(Bow b)
		{
			for (int i = 0; i < bows.Length; ++i)
			{
				if (bows[i] == null)
				{
					bows[i] = b;
					return;
				}
			}
		}
		public void AddCabbage(Cabbage cb)
		{
			for (int i = 0; i < cabbages.Length; ++i)
			{
				if (cabbages[i] == null)
				{
					cabbages[i] = cb;
					return;
				}
			}
		}
		public void AddTomato(Tomato t)
		{
			for (int i = 0; i < tomatoes.Length; ++i)
			{
				if (tomatoes[i] == null)
				{
					tomatoes[i] = t;
					return;
				}
			}
		}
		public void AddZucchini(Zucchini z)
		{
			for (int i = 0; i < zucchinies.Length; ++i)
			{
				if (zucchinies[i] == null)
				{
					zucchinies[i] = z;
					return;
				}
			}
		}

        private bool Check()
		{
			if (water.Length == 0)
			{
				return false;
			}
			if (potatos.Length == 0)
			{
				return false;
			}
			if (carrots.Length == 0)
			{
				return false;
			}
			if (tomatoes.Length == 0)
			{
				return false;
			}
			if (zucchinies.Length == 0)
			{
				return false;
			}
			if (bows.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < water.Length; ++i)
			{
				if (water[i] == null)
				{
					return false;
				}
			}
			for (int i = 0; i < potatos.Length; ++i)
			{
				if (potatos[i] == null)
				{
					return false;
				}
			}
			for (int i = 0; i < carrots.Length; ++i)
			{
				if (carrots[i] == null)
				{
					return false;
				}
			}
			for (int i = 0; i < tomatoes.Length; ++i)
			{
				if (tomatoes[i] == null)
				{
					return false;
				}
			}
			for (int i = 0; i < zucchinies.Length; ++i)
			{
				if (zucchinies[i] == null)
				{
					return false;
				}
			}
			
			for (int i = 0; i < bows.Length; ++i)
			{
				if (bows[i] == null)
				{
					return false;
				}
			}
			return true;

		}
		public void GetStew() {
			if (!Check()) {
				return;
			}
			if (water.Length > 0) {
				if (water[0].Temperature < 100) {
					for (int i = 0; i < water.Length; ++i)
					{
						water[i].GetStew();
					}
					bool flag = false;
					switch (water[0].Temperature) {
						case 20: flag = true; break;
						case 40: flag = true; break;
						case 60: flag = true; break;
						case 80: flag = true; break;
						case 100: flag = true; break;
					}
					if (flag) {
						for (int i = 0; i < potatos.Length; ++i)
						{
							potatos[i].GetStew();
						}
						for (int i = 0; i < carrots.Length; ++i)
						{
							carrots[i].GetStew();
						}
						for (int i = 0; i < zucchinies.Length; ++i)
						{
							zucchinies[i].GetStew();
						}
						for (int i = 0; i < tomatoes.Length; ++i)
						{
							tomatoes[i].GetStew();
						}
						for (int i = 0; i < bows.Length; ++i)
						{
							bows[i].GetStew();
						}
					}
				}
			}
		}

		public bool IsReady() {
            for (int i = 0; i < water.Length; ++i)
            {
                if (water[0].Temperature < 100)
                {
                    return false;
                }
            }
            for (int i = 0; i < potatos.Length; ++i)
			{
				if (potatos[i].Has_ready < 2)
				{
					return false;
                }
            }
			for (int i = 0; i < carrots.Length; ++i)
			{
				if (carrots[i].Has_ready < 2)
				{
                    return false;
				}
            }
			for (int i = 0; i < zucchinies.Length; ++i)
			{
				if (zucchinies[i].Has_ready < 2)
                {
                    return false;
				}
            }
			for (int i = 0; i < tomatoes.Length; ++i)
			{
				if (tomatoes[i].Has_ready < 2)
                {
                    return false;
				}
            }
			for (int i = 0; i < bows.Length; ++i)
			{
				if (bows[i].Has_ready < 2)
                {
                    return false;
				}
            }
			return true;
		}
		public Water[] Drain() {
			return water;
		}
		public Potato[] GetPotatos() {
			return potatos;
		}
        public Carrot[] GetCarrot()
        {
            return carrots;
        }
        public Bow[] GetBows()
        {
            return bows;
        }
        public Zucchini[] GetZuccgini()
        {
            return zucchinies;
        }
        public Tomato[] GetTomato()
        {
            return tomatoes;
        }
    }
}
