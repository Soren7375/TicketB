using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class StationService : IService<Station>
	{
		private IRepository<Station> _repository;

		public StationService(IRepository<Station> repository)
		{
			_repository = repository;
		}

		public IEnumerable<Station> Find(Dictionary<string, object> parameters)
		{
			return _repository.Find(parameters);
		}

		public Station Get(int id)
		{
			return _repository.Get(id);
		}

		public IEnumerable<Station> GetAll()
		{
			return _repository.GetAll();
		}
	}
}
