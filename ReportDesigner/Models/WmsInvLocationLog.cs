using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvLocationLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public string CErpCode { get; set; }

    public string CForeignPid { get; set; }

    public bool? CIncomingActive { get; set; }

    public DateTime? CLastInventoryDate { get; set; }

    public DateTime? CLastPickDate { get; set; }

    public string CLocationGroup { get; set; }

    public string CAisle { get; set; }

    public string CArea { get; set; }

    public string CX { get; set; }

    public string CY { get; set; }

    public string CZ { get; set; }

    public bool? CMixedProducts { get; set; }

    public int? CNoMaxTransportUnits { get; set; }

    public bool? COutgoingActive { get; set; }

    public int? CPlcState { get; set; }

    public int? CSort { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
