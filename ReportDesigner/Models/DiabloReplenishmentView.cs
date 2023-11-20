using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class DiabloReplenishmentView
{
    public long CPk { get; set; }

    public string CSku { get; set; }

    public string SourceLocation { get; set; }

    public string SoureLocationgroup { get; set; }

    public int? StockReplenshmentWarehouse { get; set; }

    public string TargetLocation { get; set; }

    public int StockOnTargetLocation { get; set; }

    public string TargetLocationGroup { get; set; }

    public string MinStock { get; set; }

    public int QtyPickOrders { get; set; }

    public int? StockToFill { get; set; }
}
