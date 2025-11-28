using System.ComponentModel;

namespace Saleling.Model.Enums
{
    public enum ReportType
    {
        [Description("Sales Summary")]
        SalesSummary,
        [Description("Inventory Stock")]
        InventoryStock,
        [Description("Inventory Movement")]
        InventoryMovement
    }
}
