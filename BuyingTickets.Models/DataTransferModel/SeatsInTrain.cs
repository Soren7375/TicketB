using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Models.DataTransferModel
{
	public class SeatsInTrain
	{
		public int TrainId { get; set; }
		public string Type { get; set; }
		public int Seats { get; set; }
	}
}
