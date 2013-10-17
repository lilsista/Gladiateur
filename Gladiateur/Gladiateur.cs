using System;

namespace Gladiateur
{
	public class Gladiateur 
	{
		private string nomGladiateur;

		public string NomGladiateur {
			get {
				return nomGladiateur;
			}
			set {
				nomGladiateur = value;
			}
		}
	

		private int nbVictoire;

		public int NbVictoire {
			get {
				return nbVictoire;
			}
			set {
				nbVictoire = value;
			}
		}

		private int nbDefaite;

		public int NbDefaite {
			get {
				return nbDefaite;
			}
			set {
				nbDefaite = value;
			}
		}


		public Equipement equipement;

		public Gladiateur (string p_nomGladiateur)
		{
			this.NomGladiateur = p_nomGladiateur;
			this.equipement.initEquipement();
		}
	}
}

