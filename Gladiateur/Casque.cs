using System;

namespace Gladiateur
{
	public class Casque : Equipement,IArmure
	{
		private static int ChanceParer = 1;

		public Casque ()
			:base(2)
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
			if (chance <= Casque.ChanceParer) {
				return "L'armure a protégée!";
			} else {
				return "L'armure n'a pas protégée!";
			}
			
		}
	}
}

