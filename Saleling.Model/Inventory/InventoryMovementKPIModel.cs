namespace Saleling.Model.Inventory
{
    public class InventoryMovementKPIModel
    {
        public int TotalUnitsSold { get; set; }
        public int TotalUnitsReceived { get; set; }
        public int NetInventoryChange { get; set; }
        public int TotalAdjustments { get; set; }
    }
}
