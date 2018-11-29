using System;
using System.Threading.Tasks;
using SharpTinder;

namespace SharpTinderExample
{
	class MainClass
	{
		const string userId = "";
		const string accessToken = "";

		static TinderClient client;

		public static void Main(string[] args)
		{
			Console.WriteLine("Sharp Tinder");

			client = new TinderClient();

			Login();
			GetUpdates();
		}

		static void Login()
		{
			var t = client.Login(userId, accessToken);
			Task.WaitAll(new Task[] { t });

			Console.WriteLine("Token: " + client.AuthToken);
			Console.WriteLine("logged in: " + t.Result);
		}

		static void GetUpdates()
		{
			// get updates
			var t = client.GetUpdates(new DateTime(2000, 01, 01));
			Task.WaitAll(new Task[] { t });
			var res = t.Result;

			foreach (var m in res.Matches)
				if (m.Person != null)
					Console.WriteLine($"{m.Person.Name} ({m.Id}) - {2016 - m.Person.BirthDate.Year}");
		}
	}
}
