using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Interface.SeatByTrain
{
	public interface ISeatByTrainService
	{
		IEnumerable<Models.DataTransferModel.SeatByTrain> GetByRoutes(string start, string end, DateTime? date, int trainId, string carType);
	}
}
