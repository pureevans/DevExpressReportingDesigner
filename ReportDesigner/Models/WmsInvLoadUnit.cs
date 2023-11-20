using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvLoadUnit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

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

    public long CTransportUnitPk { get; set; }

    public string CLoadUnitType { get; set; }

    public virtual WmsInvLoadUnitType CLoadUnitTypeNavigation { get; set; }

    public virtual WmsInvProduct CProductPkNavigation { get; set; }

    public virtual WmsInvTransportUnit CTransportUnitPkNavigation { get; set; }

    public virtual ICollection<WmsInvDiscrepancy> WmsInvDiscrepancies { get; set; } = new List<WmsInvDiscrepancy>();

    public virtual ICollection<WmsInvPackagingUnit> WmsInvPackagingUnits { get; set; } = new List<WmsInvPackagingUnit>();
}
