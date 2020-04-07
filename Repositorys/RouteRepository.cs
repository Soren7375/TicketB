using BuyingTickets.Interface;
using BuyingTickets.Models.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.DataAccess.Repositorys
{
	public class RouteRepository : BaseRepository, IRepository<Route>
	{
		public void Create(Route item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Route> Find(Dictionary<string, object> parameters)
		{
			var comm = CreateCommand.Find(parameters, "Route");
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<Route>(comm);
			}
		}

		public Route Get(int id)
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.QueryFirstOrDefault<Route>("select * from Route where RouteId = @ID", new { ID = id });
			}
		}

		public IEnumerable<Route> GetAll()
		{
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<Route>("select * from Route");
			}
		}

		public void Update(Route item)
		{
			throw new NotImplementedException();
		}
	}
}
