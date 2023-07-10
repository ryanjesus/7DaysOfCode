using RestSharp;

namespace pokeapi
{
	class Program
	{ 
		static void Main(string[] args)
		{
			InvocarGet();
		}

		private static void InvocarGet()
		{

			var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/");
			RestRequest request = new RestRequest("", Method.Get);
			var response = client.Execute(request);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
				Console.WriteLine(response.Content);
			else
			{
				Console.WriteLine(response.ErrorMessage);
			}
			Console.ReadKey();
		}
	}
}