using BuyingTickets.DataAccess.Repositorys;
using BuyingTickets.Interface;
using BuyingTickets.Models.DataTransferModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class SeatsInTrainService : IService<SeatsInTrain>
	{
		private SeatsInTrainRepository _repository;

		public SeatsInTrainService(IRepository<SeatsInTrain> repository)
		{
			_repository = (SeatsInTrainRepository)repository;
		}

		public IEnumerable<SeatsInTrain> Find(Dictionary<string, object> parameters)
		{
			throw new NotImplementedException();
		}

		public SeatsInTrain Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<SeatsInTrain> GetAll()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<SeatsInTrain> GetSeatsInTrain(string start, string end, DateTime date)
		{
			return _repository.GetSeatsInTrain(start, end, date);
		}
	}
}
