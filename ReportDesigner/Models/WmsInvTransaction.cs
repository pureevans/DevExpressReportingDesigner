using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvTransaction
{
    public long Id { get; set; }

    public string Sku { get; set; }

    public int? Quantity { get; set; }

    public string SourceTu { get; set; }

    public string SourceLocation { get; set; }

    public string TargetTu { get; set; }

    public string TargetLocation { get; set; }

    public string CallerId { get; set; }

    public string CallerType { get; set; }

    public string UserName { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string OrderId { get; set; }
}
