using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocantas.BusinessLogic.Models
{
	public class ShowModel
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Language { get; set; }
		public List<string> Genres { get; set; }
		public string Status { get; set; }
		public int Runtime { get; set; }
		public string Premiered { get; set; }
		public string OfficialSite { get; set; }
		public ScheduleModel Schedule { get; set; }
		public RatingModel Rating { get; set; }
		public int Weight { get; set; }
		public NetworkModel network { get; set; }
		public object webChannel { get; set; }
		public ExternalsModel externals { get; set; }
		public ImageModel image { get; set; }
		public string summary { get; set; }
		public int updated { get; set; }
		public LinksModel _links { get; set; }
	}
}
