using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class RouteService : IService<Route>
	{
		private IRepository<Route> _repository;

		public RouteService(IRepository<Route> repository)
		{
			_repository = repository;
		}

		public IEnumerable<Route> Find(Dictionary<string, object> parameters)
		{
			throw new NotImplementedException();
		}

		public Route Get(int id)
		{
			return _repository.Get(id);
		}

		public IEnumerable<Route> GetAll()
		{
			return _repository.GetAll();
		}
	}
}
