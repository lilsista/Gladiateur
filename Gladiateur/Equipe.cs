using System;

namespace Gladiateur
{
	public class Equipe
	{
		private string nomEquipe;

		public string NomEquipe {
			get {
				return nomEquipe;
			}
			set {
				nomEquipe = value;
			}
		}

		private string description;

		public string Description {
			get {
				return description;
			}
			set {
				description = value;
			}
		}

		private int nbMatchJouer;

		public int NbMatchJouer {
			get {
				return nbMatchJouer;
			}
			set {
				nbMatchJouer = value;
			}
		}

		private int nbMatchGagner;

		public int NbMatchGagner {
			get {
				return nbMatchGagner;
			}
			set {
				nbMatchGagner = value;
			}
		}

		private int nbMatchPerdu;

		public int NbMatchPerdu {
			get {
				return nbMatchPerdu;
			}
			set {
				nbMatchPerdu = value;
			}
		}

		public Equipe (string p_nomEquipe, string p_description)
		{
			this.NomEquipe = p_nomEquipe;
			this.Description = p_description;
		}


	}
}

