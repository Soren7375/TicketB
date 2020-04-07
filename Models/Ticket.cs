using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuyingTickets.Models
{
	public class Ticket
	{
		public int TrainId { get; set; }
		public int TrainNumber { get; set; }
		public DateTime ArivaleDateTime { get; set; }
		public DateTime DepatureDateTime { get; set; }
		public int CarId { get; set; }
		public int CarNumber { get; set; }
		public string StartStation { get; set; }
		public string EndStation { get; set; }
		public int SeatNumber { get; set; }
	}
}