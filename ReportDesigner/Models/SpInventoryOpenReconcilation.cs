using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpInventoryOpenReconcilation
{
    public string CErpCode { get; set; }

    public string CDescription { get; set; }

    public bool? COutgoingActive { get; set; }

    public bool? CIncomingActive { get; set; }

    public bool? CMixedProducts { get; set; }

    public int? CNoMaxTransportUnits { get; set; }

    public int? CPlcState { get; set; }

    public string Parentlocation { get; set; }

    public DateTime? CStartedAt { get; set; }

    public string CFromTransportUnitBk { get; set; }

    public string Locationgroup { get; set; }
}
