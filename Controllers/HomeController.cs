using BuyingTickets.BusinessLogic;
using BuyingTickets.Interface;
using BuyingTickets.Interface.SeatByTrain;
using BuyingTickets.Interface.TrainsOnRoute;
using BuyingTickets.Models;
using BuyingTickets.Models.DataTransferModel;
using BuyingTickets.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace BuyingTickets.Controllers
{
	public class HomeController : Controller
	{
		private readonly ITrainsOnRouteService _trainService;
		private readonly ISeatByTrainService _seatByTrainService;
		private readonly SeatsInTrainService _seatService;

		public HomeController(ITrainsOnRouteService trainService, IService<SeatsInTrain> seatService, ISeatByTrainService seatByTrainService)
		{
			_trainService = trainService;
			_seatByTrainService = seatByTrainService;
			_seatService = (SeatsInTrainService)seatService;
		}

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult TrainsByRoute(TrainPickInfo trainPickInfo)
		{

			var cache = new Cache();
			cache.Insert("StartStation", trainPickInfo.StartStation);
			cache.Insert("EndStation", trainPickInfo.EndStation);
			cache.Insert("Date", trainPickInfo.Date);
			var trains = _trainService.GetByRoutes(trainPickInfo.StartStation, trainPickInfo.EndStation, trainPickInfo.Date ?? DateTime.MinValue);
			var seats = _seatService.GetSeatsInTrain(trainPickInfo.StartStation, trainPickInfo.EndStation, trainPickInfo.Date ?? DateTime.MinValue);
			var trainsByroute = new  List<TrainsByRoute>();
			foreach (var train in trains)
			{
				trainsByroute.Add(new TrainsByRoute { 
											TrainId = train.TrainId, 
											TrainNumber = train.TrainNumber,	
											RouteName = train.RouteName, 
											ArrivaleDateTime = train.Date.Add(train.StartArrivale.TimeOfDay),
											DepatureDateTime = train.Date.Add(train.EndDepature.TimeOfDay),
											Seats = seats.Where(t => t.TrainId == train.TrainId).Select(i => i.Seats).ToList(),
											SeatsType = seats.Where(t => t.TrainId == train.TrainId).Select(i => i.Type).ToList()
				});
			}
			return PartialView(trainsByroute);
		}

		[HttpPost]
		public ActionResult SeatsByTrain(int trainId, int TrainNumber, DateTime ArrivaleDateTime, DateTime DepatureDateTime, string carType)
		{
			var cache = new Cache();
			var startStation = cache.Get("StartStation") as string;
			var endStation = cache.Get("EndStation") as string;
			var date = cache.Get("Date") as DateTime?;
			cache.Insert("TrainID", trainId);
			cache.Insert("TrainNumber", TrainNumber);
			cache.Insert("ArrivaleDateTime", ArrivaleDateTime);
			cache.Insert("DepatureDateTime", DepatureDateTime);
			var seats = _seatByTrainService.GetByRoutes(startStation, endStation, date, trainId, carType);
			return PartialView(seats);
		}

		public ActionResult SeatsByCar(int carId,int carNumber, string seatsNumbers)
		{
			var seats = (seatsNumbers.Split(';')).ToList();
			var cache = new Cache();
			cache.Insert("CarId", carId);
			cache.Insert("CarNumber", carNumber);
			return PartialView(seats);
		}

		public ActionResult SelectTicket(string seatNumber)
		{
			var cache = new Cache();
			var startStation = cache.Get("StartStation") as string;
			var endStation = cache.Get("EndStation") as string;
			var trainId = cache.Get("TrainID") as int?;
			var trainNumber = cache.Get("TrainNumber") as int?;
			var carID = cache.Get("CarId") as int?;
			var carNumber = cache.Get("CarNumber") as int?;
			var arrivaleDateTime = cache.Get("ArrivaleDateTime") as DateTime?;
			var depatureDateTime = cache.Get("DepatureDateTime") as DateTime?;
			var tickets = cache.Get("Tickets") as List<Ticket>;
			cache.Remove("Tickets");
			if(tickets is null)
			{
				tickets = new List<Ticket>();
			}
			tickets.Add(new Ticket {
				TrainId = (int)trainId ,
				TrainNumber = (int)trainNumber,
				ArivaleDateTime = (DateTime)arrivaleDateTime,
				DepatureDateTime = (DateTime)depatureDateTime,
				CarId = (int)carID,
				CarNumber = (int)carNumber,
				StartStation = startStation,
				EndStation = endStation,
				SeatNumber = Convert.ToInt32(seatNumber)
									});
			cache.Insert("Tickets", tickets);
			return PartialView(tickets);
		}

		//[HttpPost]
		//public ActionResult SelectStation(int id)
		//{
		//	return PartialView(_service.Get(id));
		//}
	}
}