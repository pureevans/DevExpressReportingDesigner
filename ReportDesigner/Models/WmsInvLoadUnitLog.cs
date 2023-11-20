using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvLoadUnitLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public string CUom { get; set; }

    public int? CWidth { get; set; }

    public string CLabel { get; set; }

    public bool? CLocked { get; set; }

    public bool? CMixedProducts { get; set; }

    public string CPhysicalPos { get; set; }

    public long? CProductPk { get; set; }

    public long? CTransportUnitPk { get; set; }

    public long? CLoadUnitType { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
