using System;

namespace Gladiateur
{
	public class Trident : Equipement,IArmure,IArme
	{
		private static int ChanceParer = 1;
		private static int ChanceToucher = 6;

		public Trident ()
			:base(7)
		{
		}
		/*
		public int Point ()
		{
			return this.Point;
		}
*/
		public string Attaquer ()
		{
			Random nombre = new Random ();
			int chance = nombre.Next(1,10);
			if (chance <= Trident.ChanceToucher) {
				return "L'attaque a touchée !";
			} else {
				return "L'attaque n'a pas touchée !";
			}
		}	

		public string Defendre ()
		{
			Random nombre = new Random ();
			int chance = nombre.Next(1,10);
			if (chance <= Trident.ChanceParer) {
				return "L'armure a protégée!";
			} else {
				return "L'armure n'a pas protégée!";
			}	
		}

	}
}

