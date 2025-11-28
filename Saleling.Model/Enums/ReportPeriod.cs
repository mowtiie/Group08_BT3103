using System.ComponentModel;

namespace Saleling.Model.Enums
{
    public enum ReportPeriod
    {
        [Description("Daily")]
        Daily,
        [Description("Weekly")]
        Weekly,
        [Description("Monthly")]
        Monthly,
        [Description("Yearly")]
        Yearly,
        [Description("Custom")]
        Custom
    }
}
