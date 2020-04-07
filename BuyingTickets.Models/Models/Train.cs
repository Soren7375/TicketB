using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Models.Models
{
	public class Train
	{
		public int TrainId { get; set; }
		public int TrainNumber { get; set; }
		public int TrainType { get; set; }
		public DateTime Date { get; set; }
		public int Periodicity { get; set; }
	}
}
