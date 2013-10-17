using System;

namespace Gladiateur
{
	public class Dague : Equipement,IArme
	{

		private static int ChanceToucher = 6;

		public Dague ()
			:base(2)
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
			if (chance <= Dague.ChanceToucher) {
				return "L'attaque a touchée !";
			} else {
				return "L'attaque n'a pas touchée !";
			}
		}	

	}
}

