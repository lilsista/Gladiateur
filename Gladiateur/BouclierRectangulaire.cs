using System;

namespace Gladiateur
{
	public class BouclierRectangulaire : Equipement,IArmure
	{
		private static int ChanceParer = 3;

		public BouclierRectangulaire ()
			:base(8)
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
			if (chance <= BouclierRectangulaire.ChanceParer) {
				return "L'armure a protégée!";
			} else {
				return "L'armure n'a pas protégée!";
			}
			
		}

	}
}

