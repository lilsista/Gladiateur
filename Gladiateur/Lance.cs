using System;

namespace Gladiateur
{
	public class Lance : IArme
	{
		private static int ChanceToucher = 5;

		public Lance ()
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
			if (chance <= Lance.ChanceToucher) {
				return "L'attaque a touchée !";
			} else {
				return "L'attaque n'a pas touchée !";
			}
		}	

	}
}

