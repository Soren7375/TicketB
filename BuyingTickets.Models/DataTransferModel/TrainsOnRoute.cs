 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Models.DataTransferModel
{
	public class TrainsOnRoute
	{
		public int TrainId { get; set; }
		public int TrainNumber { get; set; }
		public string RouteName { get; set; }
		public DateTime Date { get; set; }
		public DateTime StartArrivale { get; set; }
		public DateTime EndDepature { get; set; }

	}
}
