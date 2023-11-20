using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvLocation
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

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

    public int? CSplsDispo { get; set; }

    public int CSingleMaxTransportUnits { get; set; }

    public int CLocationType { get; set; }

    public bool? CDirectBookingAllowed { get; set; }

    public bool CNoInboundMovement { get; set; }

    public bool CMovementTarget { get; set; }

    public bool CIsReceivingLocation { get; set; }

    public string CMainLocationGroup { get; set; }

    public bool CIsActiveLocation { get; set; }

    public bool CIsTargetForMvm { get; set; }

    public virtual ICollection<WmsInvArticleLocationMap> WmsInvArticleLocationMaps { get; set; } = new List<WmsInvArticleLocationMap>();

    public virtual ICollection<WmsInvDiscrepancy> WmsInvDiscrepancies { get; set; } = new List<WmsInvDiscrepancy>();

    public virtual ICollection<WmsInvFillLevel> WmsInvFillLevels { get; set; } = new List<WmsInvFillLevel>();

    public virtual ICollection<WmsInvPackagingUnit> WmsInvPackagingUnits { get; set; } = new List<WmsInvPackagingUnit>();

    public virtual ICollection<WmsInvPickOrderPosSplit> WmsInvPickOrderPosSplits { get; set; } = new List<WmsInvPickOrderPosSplit>();

    public virtual ICollection<WmsInvPickOrder> WmsInvPickOrders { get; set; } = new List<WmsInvPickOrder>();

    public virtual ICollection<WmsInvProduct> WmsInvProducts { get; set; } = new List<WmsInvProduct>();

    public virtual ICollection<WmsInvTransportUnit> WmsInvTransportUnits { get; set; } = new List<WmsInvTransportUnit>();
}
