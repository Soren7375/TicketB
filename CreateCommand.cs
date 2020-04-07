using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.DataAccess
{
	public static class CreateCommand
	{
		public static string Find(Dictionary<string, object> parameters, string table)
		{
			var filter = new List<string>();
			foreach (var item in parameters)
			{
				filter.Add(string.Join(" = ", item.Key, $"'{item.Value.ToString()}'"));
			}
			var comm = $"Select * from {table} {(parameters.Count != 0 ? " where ": string.Empty)} {string.Join(" and ", filter)}";
			return comm;
		}
	}
}
