using BuyingTickets.Interface.TrainsOnRoute;
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
	public class TrainOnRouteRepository : BaseRepository, ITrainOnRouteRepository
	{

		public void Create(TrainsOnRoute item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
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
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<TrainsOnRoute>("GetAllTrains", new { @Start = start, @End = end, @Date = date }, commandType: CommandType.StoredProcedure);
			}
		}

		public void Update(TrainsOnRoute item)
		{
			throw new NotImplementedException();
		}
	}
}
