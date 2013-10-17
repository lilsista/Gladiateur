using System;

namespace Gladiateur
{
	public class Epee : IArme
	{
		private static int ChanceToucher = 7;

		public Epee ()
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
			if (chance <= Epee.ChanceToucher) {
				return "L'attaque a touchée !";
			} else {
				return "L'attaque n'a pas touchée !";
			}
		}	

	}
}

