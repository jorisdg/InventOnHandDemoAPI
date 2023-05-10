namespace InventOnHandDemoAPI.Models
{
    public record Warehouse
    {
        public string City { get; set; }

    }

    public record InventOnHand
    {
        public string ItemId { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int numberInStock { get; set; }
    }

    public class InventoryDB
    {
        private static List<Warehouse> _warehouses = new List<Warehouse>()
    {
        new Warehouse {City = "Seattle"},
        new Warehouse {City = "Redmond"},
        new Warehouse {City = "Tacoma"},
        new Warehouse {City = "Issaquah"},
        new Warehouse {City = "Everett"}
    };

        public static List<Warehouse> GetWarehouses()
        {
            return _warehouses;
        }

        private static List<InventOnHand> _onHandItems = new List<InventOnHand>()
    {
        new InventOnHand() {ItemId = "1", City = "Seattle", numberInStock= 3, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Description = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Redmond", numberInStock= 2, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Description = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Tacoma", numberInStock= 1, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Description = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Issaquah", numberInStock= 0, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Description = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Everett", numberInStock= 0, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Description = "Water pump controller for combination boiler"},

        new InventOnHand() {ItemId = "2", City = "Seattle", numberInStock= 3, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Description = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Redmond", numberInStock= 1, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Description = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Tacoma", numberInStock= 0, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Description = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Issaquah", numberInStock= 4, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Description = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Everett", numberInStock= 8, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Description = "Small heat exchanger for domestic boiler"},

        new InventOnHand() {ItemId = "3", City = "Seattle", numberInStock= 7, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Description = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Redmond", numberInStock= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Description = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Tacoma", numberInStock= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Description = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Issaquah", numberInStock= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Description = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Everett", numberInStock= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Description = "Water inlet valve with one - way operation"}
    };

        public static List<InventOnHand> GetInventOnHand(string Id)
        {
            return _onHandItems.Where(i => i.City == Id).ToList();
        }

        public static List<InventOnHand> GetInventOnHand()
        {
            return _onHandItems.ToList();
        }
    }
}
