using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_12_22_Placa
{
    internal class Zaposlenik
    {
        public string Ime { get; set; }

		private int placaPoSatu;

		public int PlacaPoSatu
		{
			get { return placaPoSatu; }
			set 
			{
				if (value >= 17 && value <= 25)
				{
                    placaPoSatu = value;
					Racunaj();
                }	
				else
					throw new ArgumentException("Plaća po satu mora iznositi između 17 i 25 kuna!");
			}
		}

		private int brojRadnihSati;

		public int BrojRadnihSati
		{
			get { return brojRadnihSati; }
			set 
			{
				if (value >= 6 && value <= 10)
				{
					brojRadnihSati = value;
					Racunaj();
				}
				else
					throw new ArgumentException("Broj radnih sati mora biti između 6 i 10!");				
			}
		}
		private double ukupnaPlaca;

		public double UkupnaPlaca
		{
			get { return ukupnaPlaca; }		
		}

		private void Racunaj()
		{
			ukupnaPlaca = BrojRadnihSati * PlacaPoSatu;
		}

		public Zaposlenik(string ime, int placaPoSatu, int broRadnihSati)
		{
			Ime = ime;
			PlacaPoSatu = placaPoSatu;
			BrojRadnihSati = broRadnihSati;
		}

	}
}
