using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocantsBusinessLogic.Models;

namespace VocantsBusinessLogic.Interface
{
	public interface ITvMazeManager
	{
		List<TvMazeViewModel> GetData();
	}
}
