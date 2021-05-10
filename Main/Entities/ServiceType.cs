namespace Main.Entities {
	public class ServiceType {
		public int IdServiceType { get; set; }
		public int IdTools { get; set; }
		public int Price { get; set; }
		public int IdSupplies { get; set; }
		public string Description { get; set; }
		public string Name { get; set; }

		public ServiceType(int idServiceType, int idTools, int price, int idSupplies, string description, string name) {
			IdServiceType = idServiceType;
			IdTools = idTools;
			Price = price;
			IdSupplies = idSupplies;
			Description = Description;
			Name = name;
		}
	}
}
