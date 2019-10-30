using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;
using VocantsBusinessLogic.Interface;
using VocantsBusinessLogic.Models;

namespace VocantsBusinessLogic.Manager
{
	public class TvMazeManager : ITvMazeManager
	{
		private readonly ITvMazeManager _TvMazeManager;
		private string _authEndpointAddress = String.Empty;


		public TvMazeManager(ITvMazeManager vocantasManager)
		{
			_TvMazeManager = vocantasManager;
			_authEndpointAddress = ConfigurationManager.AppSettings["Vocantas.Client.Endpoint"];
		}
		public TvMazeManager()
		{
			_authEndpointAddress = ConfigurationManager.AppSettings["Vocantas.Client.Endpoint"];
		}
		public List<TvMazeViewModel> GetData()
		{
			List<TvMazeViewModel> tvMazes = new List<TvMazeViewModel>();
			var result = GenerateTvMaze().Result.Content.ReadAsStringAsync().Result;

			var jsonresult =
				JsonConvert.DeserializeObject<List<TvMazeModel>>(result);

			foreach (var data in jsonresult)
			{
				TvMazeViewModel response = new TvMazeViewModel()
				{
					Genres = string.Join(",", data.show.Genres),
					Name = data.show.Name,
					Premiered = data.show.Premiered,
					Rating = data.show.Rating.Average,
					Summary = data.show.summary
				};

				tvMazes.Add(response);

			}



			return new List<TvMazeViewModel>(tvMazes);

		}

		public async Task<HttpResponseMessage> GenerateTvMaze()
		{

			using (var handler = new HttpClientHandler { UseDefaultCredentials = true })
			using (var client = new HttpClient(handler))
			{
				client.BaseAddress = new Uri(_authEndpointAddress);
				client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "true");

				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				var response = client.GetAsync("");
				return response.Result;
			}

		}

	}
}
