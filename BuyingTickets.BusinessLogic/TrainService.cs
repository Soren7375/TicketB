using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class TrainService : IService<Train>
	{
		private IRepository<Train> _repository;

		public TrainService(IRepository<Train> repository)
		{
			_repository = repository;
		}

		public IEnumerable<Train> Find(Dictionary<string, object> parameters)
		{
			throw new NotImplementedException();
		}

		public Train Get(int id)
		{
			return _repository.Get(id);
		}

		public IEnumerable<Train> GetAll()
		{
			return _repository.GetAll();
		}
	}
}
