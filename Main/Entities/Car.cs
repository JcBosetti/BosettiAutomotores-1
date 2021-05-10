using System;

namespace Main.Entities {
	public class Car {
		public string Plate { get; set; }
		public DateTime Year { get; set; }
		public int IdModel { get; set; }
		public string Serie { get; set; }

		public Car(string plate, DateTime year, int idModel, string serie) {
			Plate = plate;
			Year = year;
			IdModel = idModel;
			Serie = serie;
		}
	}
}
