using BuyingTickets.Interface.SeatByTrain;
using BuyingTickets.Models.DataTransferModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.BusinessLogic
{
	public class SeatByTrainService : ISeatByTrainService
	{
		private readonly ISeatByTrainRepository _seatByTrainRepository;

		public SeatByTrainService(ISeatByTrainRepository seatByTrainRepository)
		{
			_seatByTrainRepository = seatByTrainRepository;
		}

		public IEnumerable<SeatByTrain> GetByRoutes(string start, string end, DateTime? date, int trainId, string carType)
		{
			return _seatByTrainRepository.GetByRoutes(start, end, date, trainId, carType);
		}
	}
}
