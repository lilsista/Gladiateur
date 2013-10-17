using System;

namespace Gladiateur
{
	public class Filet : IArme
	{
		private static int ChanceToucher = 3;

		public Filet ()
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
			if (chance <= Filet.ChanceToucher) {
				return "L'attaque a touchée !";
			} else {
				return "L'attaque n'a pas touchée !";
			}
		}	

	}
}

