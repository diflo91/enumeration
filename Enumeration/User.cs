using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	public class User
	{
		public string Nom {  get; set; }
		public string Prenom { get; set; }
		public ECouleurs Couleur { get; set; }

		public User()
		{
			
		}

		public static void CountCoulor(params User[] _users)
		{
			List<User> _user = new List<User>(_users);

				var check_R = _user.Where(c => c.Couleur == ECouleurs.ROUGE);
				var check_B = _user.Where(c => c.Couleur == ECouleurs.BLEU);
				var check_V = _user.Where(c => c.Couleur == ECouleurs.VERT);
				var check_J = _user.Where(c => c.Couleur == ECouleurs.JAUNE);


				Console.WriteLine($"{ECouleurs.ROUGE} : {check_R.Count()}");
				Console.WriteLine($"{ECouleurs.BLEU} : {check_B.Count()}");
				Console.WriteLine($"{ECouleurs.VERT} : {check_V.Count()}");
				Console.WriteLine($"{ECouleurs.JAUNE} : {check_J.Count()}");
			

		}


	}
}
