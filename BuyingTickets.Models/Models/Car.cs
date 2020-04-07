using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingTickets.Models.Models
{
	public class Car
	{
		public int CarId { get; set; }
		public int TrainId { get; set; }
		public CarType CarType { get; set; }
	}

	public enum CarType
	{
		K,
		P
	}

}
