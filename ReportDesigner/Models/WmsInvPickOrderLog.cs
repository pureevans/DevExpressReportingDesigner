using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public string CUser { get; set; }

    public DateTime? CEarliestStartedAt { get; set; }

    public DateTime? CFinishedAt { get; set; }

    public string COrderId { get; set; }

    public string COrderType { get; set; }

    public bool? CShared { get; set; }

    public string CSourceLocationGroup { get; set; }

    public string CStartMode { get; set; }

    public DateTime? CStartedAt { get; set; }

    public string CState { get; set; }

    public long? CDropLocationPk { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
