using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class DiabloReplenishmentLocationgroup
{
    public long CPk { get; set; }

    public string CSku { get; set; }

    public string CDescription { get; set; }

    public string TargetLocationGroup { get; set; }

    public int StockOnTargetLocationGroup { get; set; }

    public string MinStock { get; set; }

    public int QtyPickOrders { get; set; }
}
