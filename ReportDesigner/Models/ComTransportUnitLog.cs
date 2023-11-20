using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComTransportUnitLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public DateTime? CActualLocationDate { get; set; }

    public string CBarcode { get; set; }

    public bool? CEmpty { get; set; }

    public string CGroupId { get; set; }

    public DateTime? CInventoryDate { get; set; }

    public string CInventoryUser { get; set; }

    public string CState { get; set; }

    public decimal? CWeight { get; set; }

    public int? CWeightUom { get; set; }

    public long? CActualLocation { get; set; }

    public long? CParent { get; set; }

    public long? CTargetLocation { get; set; }

    public long? CTransportUnitType { get; set; }
}
