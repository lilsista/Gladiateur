using System;

namespace Gladiateur
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			/*

			// Définition des variables du joueur
			string jNom, jPrenom,jPseudo;
			// Définition des varibles de l'equipe
			string eNom, eDescription;
			// Définition des varibles du gladiateur
			string gNom;

			// Instansiation du Joueur
			Console.WriteLine ("entrer votre nom");
			jNom = Console.ReadLine();
			Console.WriteLine ("entrer votre prenom");
			jPrenom = Console.ReadLine();
			Console.WriteLine ("entrer votre pseudo");
			jPseudo = Console.ReadLine();

			Joueur j1 = new Joueur(jNom,jPrenom,jPseudo);
			Console.WriteLine(j1.Nom +" "+ j1.Prenom+ " "+ j1.Pseudo);

			// Instansiation des Gladiateurs
			Console.WriteLine ("entrer le nom du gladiateur");
			gNom = Console.ReadLine();
			
			Gladiateur gladiateur1 = new Gladiateur(gNom);
			Console.WriteLine(gladiateur1.NomGladiateur);

			// Instansiation de l'equipe
			Console.WriteLine ("entrer le nom de l'équipe");
			eNom = Console.ReadLine();
			Console.WriteLine ("entrer la description de l'équipe");
			eDescription = Console.ReadLine();

			Equipe equipe1 = new Equipe(eNom,eDescription);
			Console.WriteLine(equipe1.NomEquipe +" "+ equipe1.Description);

			*/


			Joueur j1 = new Joueur("yeg","gok","lee");
			Console.WriteLine(j1.Nom +" "+ j1.Prenom+ " "+ j1.Pseudo);
			Joueur j2 = new Joueur("lil","lol","ach");
			Console.WriteLine(j2.Nom +" "+ j2.Prenom+ " "+ j2.Pseudo);

			Equipe equipe1 = new Equipe("equipe1","aka");
			Console.WriteLine(equipe1.NomEquipe +" "+ equipe1.Description);
			Equipe equipe2 = new Equipe("equipe2","kono");
			Console.WriteLine(equipe2.NomEquipe +" "+ equipe2.Description);

			Console.WriteLine("Choisissez votre action:");
			Console.WriteLine("1- Combattre");
			Console.WriteLine("2- Créer une équipe");

			string ch = Console.ReadLine();

			switch ( ch ){
				case "1":
					Combat c = new Combat();
					break;
				case "2":
					Equipe n = new Equipe();
					break;
				default :
					Console.WriteLine("Selectionnez 1 ou 2");
					break;
			}

			//Combat c = new Combat(equipe1,equipe2);



		}
	}
}
