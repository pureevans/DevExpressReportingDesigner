using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvTask
{
    public string CDisc { get; set; }

    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CState { get; set; }

    public string LoadUnitType { get; set; }

    public int? Parts { get; set; }

    public string TransportUnitbk { get; set; }

    public string CustomerOrderId { get; set; }
}
