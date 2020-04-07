using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Models.DataTransferModel
{
	public class SeatByTrain
	{
		public int TrainId { get; set; }
		public int CarId { get; set; }
		public int SeatId { get; set; }
		public int? SeatNumber { get; set; }
	}
}
