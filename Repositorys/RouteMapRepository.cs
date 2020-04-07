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
	public class RouteMapRepository : BaseRepository, IRepository<RouteMap>
	{
		public void Create(RouteMap item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteMap> Find(Dictionary<string, object> parameters)
		{
			var comm = CreateCommand.Find(parameters, "RoutMap");
			using (Connection)
			{
				Connection.Open();
				return Connection.Query<RouteMap>(comm);
			}
		}

		public RouteMap Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<RouteMap> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Update(RouteMap item)
		{
			throw new NotImplementedException();
		}
	}
}
