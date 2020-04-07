using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyingTickets.Interface.SeatByTrain;
using BuyingTickets.Models.DataTransferModel;
using Dapper;

namespace BuyingTickets.DataAccess
{
	public class SeatByTrainRepository : BaseRepository, ISeatByTrainRepository
	{
		public IEnumerable<SeatByTrain> GetByRoutes(string start, string end, DateTime? date, int trainId, string carType)
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<SeatByTrain>("GetAllSeatsInTrain", new { @Start = start, @End = end, @Date = date, @TrainId = trainId, @CarType = carType }, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
