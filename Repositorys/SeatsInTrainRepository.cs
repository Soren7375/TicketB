using BuyingTickets.Interface;
using BuyingTickets.Models.DataTransferModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.DataAccess.Repositorys
{
	public class SeatsInTrainRepository : BaseRepository, IRepository<SeatsInTrain>
	{
		public void Create(SeatsInTrain item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
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

		public void Update(SeatsInTrain item)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<SeatsInTrain> GetSeatsInTrain(string start, string end, DateTime date)
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<SeatsInTrain>("GetSeatsData", new { @Start = start, @End = end, @Date = date }, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
