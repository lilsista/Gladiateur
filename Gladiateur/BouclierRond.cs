using System;

namespace Gladiateur
{
	public class BouclierRond : Equipement,IArmure
	{
		private static int ChanceParer = 2;

		public BouclierRond ()
			:base(5)
		{

		}
		/*
		public int Point ()
		{
			return this.Point;
		}
*/
		public string Defendre ()
		{
			Random nombre = new Random ();
			int chance = nombre.Next(1,10);
			if (chance <= BouclierRond.ChanceParer) {
				return "L'armure a protégée!";
			} else {
				return "L'armure n'a pas protégée!";
			}

		}

	}
}

