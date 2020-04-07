using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.DataAccess
{
	public class StationRepository : BaseRepository, IRepository<Station>
	{

		public Station Get(int id)
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.QueryFirstOrDefault<Station>("select * from Station where StationId = @ID", new { ID = id });
			}
		}

		public IEnumerable<Station> GetAll()
		{
			using(Connection)
			{
				Connection.Open();
				return Connection.Query<Station>("GetAllStation", CommandType.StoredProcedure);
			}
		}

		public void Update(Station item)
		{
			throw new NotImplementedException();
		}

		public void Create(Station item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
		
		public IEnumerable<Station> Find(Dictionary<string, object> parameters)
		{
			var comm = CreateCommand.Find(parameters, "Station");
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<Station>(comm);
			}
		}
	}
}
