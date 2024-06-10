using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Enumeration
{
	internal class Program
	{
		static void Main(string[] args)
		{
			User user = new User();
			user.Nom = "John";
			user.Prenom = "Doe";
			user.Couleur = ECouleurs.ROUGE;

			User user2 = new User();
			user2.Nom = "Paule";
			user2.Prenom = "Roger";
			user2.Couleur = ECouleurs.BLEU;

			User user3 = new User();
			user3.Nom = "Mireille";
			user3.Prenom = "Boll";
			user3.Couleur = ECouleurs.ROUGE;

			User user4 = new User();
			user4.Nom = "Christiana";
			user4.Prenom = "Piter";
			user4.Couleur = ECouleurs.ROUGE;




			Console.WriteLine($"{user.Nom} {user.Prenom} {user.Couleur.GetDescription()}");
			Console.WriteLine($"{user2.Nom} {user2.Prenom} {user2.Couleur.GetDescription()}");
			Console.WriteLine($"{user3.Nom} {user3.Prenom} {user3.Couleur.GetDescription()}");
			Console.WriteLine($"{user4.Nom} {user4.Prenom} {user4.Couleur.GetDescription()}");



			Console.WriteLine($" ///////////////////////////////////////////////////////////////////////");

			foreach (string c in Enum.GetNames(typeof(ECouleurs)))
				Console.WriteLine(c);

			Console.WriteLine($" ///////////////////////////////////////////////////////////////////////");

			User.CountCoulor(user, user2, user3, user4);
			
			
		}
	}
}
