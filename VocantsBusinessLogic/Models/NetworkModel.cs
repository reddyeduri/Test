using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocantas.BusinessLogic.Models
{
	public class NetworkModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public CountryModel Country { get; set; }
	}
}
