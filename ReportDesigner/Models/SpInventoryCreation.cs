using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpInventoryCreation
{
    public string CErpCode { get; set; }

    public string CDescription { get; set; }

    public bool? COutgoingActive { get; set; }

    public bool? CIncomingActive { get; set; }

    public bool? CMixedProducts { get; set; }

    public int? CNoMaxTransportUnits { get; set; }

    public int? CPlcState { get; set; }

    public string Parentlocation { get; set; }

    public string Locationgroup { get; set; }

    public DateTime? CLastInventoryDate { get; set; }

    public string CX { get; set; }

    public string CY { get; set; }

    public string CZ { get; set; }

    public string CArea { get; set; }

    public string CAisle { get; set; }

    public int? CSort { get; set; }
}
