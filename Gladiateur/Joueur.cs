using System;

namespace Gladiateur
{
	public class Joueur
	{
		private string nom;

		public string Nom {
			get {
				return nom;
			}
			set {
				nom = value;
			}
		}

		private string prenom;

		public string Prenom {
			get {
				return prenom;
			}
			set {
				prenom = value;
			}
		}

		private string pseudo;

		public string Pseudo {
			get {
				return pseudo;
			}
			set {
				pseudo = value;
			}
		}

		private DateTime dateInscription;

		public DateTime DateInscription {
			get {
				return dateInscription;
			}
			set {
				dateInscription = value;
			}
		}

		public Joueur (string p_nom, string p_prenom, string p_pseudo)
		{
			this.Nom = p_nom;
			this.Prenom = p_prenom;
			this.Pseudo = p_pseudo;
		}

	


	}
}

