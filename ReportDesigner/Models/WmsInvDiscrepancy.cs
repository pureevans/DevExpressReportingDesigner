using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvDiscrepancy
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime? CApprovedAt { get; set; }

    public string CApprovedBy { get; set; }

    public DateTime CCountedAt { get; set; }

    public string CCountedBy { get; set; }

    public string CQtyCountedType { get; set; }

    public string CQtyCounted { get; set; }

    public string CQtyExpectedType { get; set; }

    public string CQtyExpected { get; set; }

    public long CProductPk { get; set; }

    public long? CLoadUnitPk { get; set; }

    public long? CLocationPk { get; set; }

    public string CSenderId { get; set; }

    public string CTraceId { get; set; }

    public virtual WmsInvLoadUnit CLoadUnitPkNavigation { get; set; }

    public virtual WmsInvLocation CLocationPkNavigation { get; set; }

    public virtual WmsInvProduct CProductPkNavigation { get; set; }
}
