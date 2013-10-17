using System;

namespace Gladiateur
{
	public class Equipement
	{
		private static int pointMax = 10;

		private int point;

		public int Point {
			get {
				return point;
			}
			set {
				point = value;
			}
		}

		public Equipement (int p_point)
		{
			this.Point = p_point;
		}

		public void initEquipement(){
			int pointRestant = Equipement.pointMax;

			while (pointRestant > 0) {
				Console.WriteLine ("Veuillez selectionner Vos equipement: point restant = "+ pointRestant);
				Console.WriteLine ("1- Dague ( 2 points )");
				Console.WriteLine ("2- Epée ( 5 points )");
				Console.WriteLine ("3- Lance ( 7 points )");
				Console.WriteLine ("4- Trident ( 7 points )");
				Console.WriteLine ("5- Filet ( 3 points )");
				Console.WriteLine ("6- Petit bouclier rond ( 3 points )");
				Console.WriteLine ("7- Bouclier Rectangulaire ( 8 points )");
				Console.WriteLine ("8- Casque ( 2 points )");
				/*
				string choix = Console.ReadLine();

				switch ( choix ){
					case "1": 
						Dague d = new Dague();
						pointRestant -= d.Point();
						break;
					case "2": 
						Epee e = new Epee();
						pointRestant -= e.Point();
						break;
					case "3": 
						Lance l = new Lance();
						pointRestant -= l.Point();
						break;
					case "4": 
						Trident t = new Trident();
						pointRestant -= t.Point();
						break;
					case "5": 
						Filet f = new Filet();
						pointRestant -= f.Point();
						break;
					case "6": 
						BouclierRond bRond = new BouclierRond();
						pointRestant -= bRond.Point();
						break;
					case "7": 
						BouclierRectangulaire bRec = new BouclierRectangulaire();
						pointRestant -= bRec.Point();
						break;
					case "8": 
						Casque c = new Casque();
						pointRestant -= c.Point();
						break;
					default:
						Console.WriteLine("Veuillez ecrire le numero corespondant à votre choix");
						break;
				}
				*/
			}

		}

	}
}

