using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.DataAccess.Repositorys
{
	public class TrainRepository : BaseRepository, IRepository<Train>
	{
		public void Create(Train item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Train> Find(Dictionary<string, object> parameters)
		{
			using (Connection)
			{
				Connection.Open();
				foreach (var parameter in parameters)
				{

				}
				return Connection.Query<Train>("select * from Train where TrainId = @TrainId");
			}
		}

		public Train Get(int id)
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.QuerySingle<Train>("select * from Train where TrainId = @TrainId", new { TrainId = id});
			}
		}

		public IEnumerable<Train> GetAll()
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<Train>("select * from Train");
			}
		}

		public void Update(Train item)
		{
			throw new NotImplementedException();
		}
	}
}
