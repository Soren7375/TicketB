using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuyingTickets.Models
{
	public class TrainPickInfo
	{
		public string StartStation { get; set; }
		public string EndStation { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{mm.dd.yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? Date { get; set; }
	}
}