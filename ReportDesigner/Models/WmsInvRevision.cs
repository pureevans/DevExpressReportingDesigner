using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvRevision
{
    public long CPk { get; set; }

    public long? CTimestamp { get; set; }

    public string CUser { get; set; }

    public string CTraceId { get; set; }

    public virtual ICollection<WmsInvLoadUnitLog> WmsInvLoadUnitLogs { get; set; } = new List<WmsInvLoadUnitLog>();

    public virtual ICollection<WmsInvLocationLog> WmsInvLocationLogs { get; set; } = new List<WmsInvLocationLog>();

    public virtual ICollection<WmsInvPackagingUnitLog> WmsInvPackagingUnitLogs { get; set; } = new List<WmsInvPackagingUnitLog>();

    public virtual ICollection<WmsInvPickDetailLog> WmsInvPickDetailLogs { get; set; } = new List<WmsInvPickDetailLog>();

    public virtual ICollection<WmsInvPickOrderLog> WmsInvPickOrderLogs { get; set; } = new List<WmsInvPickOrderLog>();

    public virtual ICollection<WmsInvPickOrderPosSplitLog> WmsInvPickOrderPosSplitLogs { get; set; } = new List<WmsInvPickOrderPosSplitLog>();

    public virtual ICollection<WmsInvPickOrderPositionLog> WmsInvPickOrderPositionLogs { get; set; } = new List<WmsInvPickOrderPositionLog>();

    public virtual ICollection<WmsInvPickOrderTuLog> WmsInvPickOrderTuLogs { get; set; } = new List<WmsInvPickOrderTuLog>();

    public virtual ICollection<WmsInvProductLog> WmsInvProductLogs { get; set; } = new List<WmsInvProductLog>();

    public virtual ICollection<WmsInvReservationLog> WmsInvReservationLogs { get; set; } = new List<WmsInvReservationLog>();
}
