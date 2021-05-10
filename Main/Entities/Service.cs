using System;

namespace Main.Entities {
	public class Service {
		public int IdService { get; set; }
		public int IdServiceType { get; set; }
		public int IdEmployee { get; set; }
		public int LastServiceKm { get; set; }
		public string CuilClient { get; set; }
		public string Plate { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime LastServiceDate { get; set; }

		public Service(int idService, int idServiceType, int idEmployee, int lastServiceKm, string cuilClient, string plate, DateTime beginDate, DateTime endDate, DateTime lastServiceDate) {
			CuilClient = cuilClient;
			IdService = idService;
			IdServiceType = idServiceType;
			IdEmployee = idEmployee;
			LastServiceKm = lastServiceKm;
			CuilClient = cuilClient;
			Plate = plate;
			BeginDate = beginDate;
			EndDate = endDate;
			LastServiceDate = lastServiceDate;
		}
	}
}
