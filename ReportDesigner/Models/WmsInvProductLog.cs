using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProductLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public string CAccount { get; set; }

    public string CAvState { get; set; }

    public string CBaseUnitType { get; set; }

    public string CBaseUnitQty { get; set; }

    public string CClassification { get; set; }

    public string CDescription { get; set; }

    public string CDescriptionText { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public string CUom { get; set; }

    public int? CWidth { get; set; }

    public string CGroup { get; set; }

    public string CLabel { get; set; }

    public string CWeightType { get; set; }

    public string CWeight { get; set; }

    public string CSku { get; set; }

    public string CStockZone { get; set; }

    public long? CPreferableStorageLocation { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
