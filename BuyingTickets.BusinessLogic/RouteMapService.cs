using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class RouteMapService : IService<RouteMap>
	{

		private IRepository<RouteMap> _routeMapRepository;


		public RouteMapService(IRepository<RouteMap> routeMapRepository)
		{
			_routeMapRepository = routeMapRepository;
		}

		public IEnumerable<RouteMap> Find(Dictionary<string, object> parameters)
		{
			return _routeMapRepository.Find(parameters);
		}

		public RouteMap Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteMap> GetAll()
		{
			throw new NotImplementedException();
		}
	}
}
