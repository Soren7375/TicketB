using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Interface.TrainsOnRoute
{
	public interface ITrainsOnRouteService : IService<Models.DataTransferModel.TrainsOnRoute>
	{
		IEnumerable<Models.DataTransferModel.TrainsOnRoute> GetByRoutes(string start, string end, DateTime date);
	}
}
