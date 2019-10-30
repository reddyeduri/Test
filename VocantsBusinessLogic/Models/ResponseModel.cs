using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocantas.BusinessLogic.Models
{
	public class ResponseModel
	{

		public string Name { get; set; }
		public string Genres { get; set; }
		public string Premiered { get; set; }
		public double? Rating { get; set; }
		public string Summary { get; set; }

	}
}
