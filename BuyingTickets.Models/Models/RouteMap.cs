using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Models.Models
{
	public class RouteMap
	{
		public int RouteId { get; set; }
		public int StationId { get; set; }
		public int DistanceTo { get; set; }
		public DateTime DepartureTime { get; set; }
		public int WaitingTime { get; set; }
	}
}
