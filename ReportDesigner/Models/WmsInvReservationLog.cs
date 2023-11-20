using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvReservationLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public string CQtyTypeReserved { get; set; }

    public string CQtyReserved { get; set; }

    public DateTime? CReservedAt { get; set; }

    public string CReservedBy { get; set; }

    public long? CPackagingUnitPk { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
