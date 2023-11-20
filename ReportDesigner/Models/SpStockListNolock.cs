using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpStockListNolock
{
    public string CSku { get; set; }

    public string CTransportUnitBk { get; set; }

    public string CDescription { get; set; }

    public int? Stock { get; set; }

    public string Location { get; set; }

    public string Locationdesc { get; set; }

    public string Locationgrouploc { get; set; }

    public string MainLocationGroup { get; set; }

    public int? Isdispo { get; set; }

    public string CLabel { get; set; }

    public int CNoMaxTransportUnits { get; set; }

    public int CSingleMaxTransportUnits { get; set; }

    public int CNumberPerTu { get; set; }

    public int CStackingFactor { get; set; }

    public DateTime? CLastInventoryDate { get; set; }

    public int? CSort { get; set; }

    public long ProductPk { get; set; }

    public long? LocationPk { get; set; }

    public string CArea { get; set; }

    public int? CLocationType { get; set; }

    public long? TranportUnitPk { get; set; }

    public long? CMvmTransportorderPosId { get; set; }
}
