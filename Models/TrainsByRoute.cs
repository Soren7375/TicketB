using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyingTickets.Models
{
	public class TrainsByRoute
	{
		public int TrainId { get; set; }
		public int TrainNumber { get; set; }
		public string RouteName { get; set; }
		public DateTime ArrivaleDateTime { get; set; }
		public DateTime DepatureDateTime { get; set; }
		//TODO: Add Enum
		public List<string> SeatsType { get; set; }
		public List<int> Seats { get; set; }

	}
}