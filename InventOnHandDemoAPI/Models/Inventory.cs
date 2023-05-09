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
        public string Overview { get; set; }
        public int Qty { get; set; }
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
        new InventOnHand() {ItemId = "1", City = "Seattle", Qty= 3, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Overview = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Redmond", Qty= 2, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Overview = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Tacoma", Qty= 1, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Overview = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Issaquah", Qty= 0, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Overview = "Water pump controller for combination boiler"},
        new InventOnHand() {ItemId = "1", City = "Everett", Qty= 0, Name = "Pumped Water Controller", CategoryId = "PCB Assembly", Price = 45.9900, Overview = "Water pump controller for combination boiler"},

        new InventOnHand() {ItemId = "2", City = "Seattle", Qty= 4, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Overview = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Redmond", Qty= 1, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Overview = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Tacoma", Qty= 0, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Overview = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Issaquah", Qty= 4, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Overview = "Small heat exchanger for domestic boiler"},
        new InventOnHand() {ItemId = "2", City = "Everett", Qty= 4, Name = "3.5 W / S Heater", CategoryId = "Heat Exchanger", Price = 125.5000, Overview = "Small heat exchanger for domestic boiler"},

        new InventOnHand() {ItemId = "3", City = "Seattle", Qty= 7, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Overview = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Redmond", Qty= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Overview = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Tacoma", Qty= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Overview = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Issaquah", Qty= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Overview = "Water inlet valve with one - way operation"},
        new InventOnHand() {ItemId = "3", City = "Everett", Qty= 0, Name = "Inlet Valve", CategoryId = "Valve", Price = 120.2000, Overview = "Water inlet valve with one - way operation"}
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
