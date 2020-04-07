using BuyingTickets.DataAccess.Repositorys;
using BuyingTickets.Interface;
using BuyingTickets.Interface.TrainsOnRoute;
using BuyingTickets.Models.DataTransferModel;
using BuyingTickets.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class TrainsOnRouteService : ITrainsOnRouteService
	{
		private ITrainOnRouteRepository _repository;

		public TrainsOnRouteService(ITrainOnRouteRepository repository)
		{
			_repository = repository;
		}

		public IEnumerable<TrainsOnRoute> Find(Dictionary<string, object> parameters)
		{
			throw new NotImplementedException();
		}

		public TrainsOnRoute Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TrainsOnRoute> GetAll()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<TrainsOnRoute> GetByRoutes(string start, string end, DateTime date)
		{
			return _repository.GetByRoutes(start, end, date);
		}
	}
}
