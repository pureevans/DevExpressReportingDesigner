using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrder
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

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

    public int? CPriority { get; set; }

    public string CAssignedUser { get; set; }

    public string CPickUserGroup { get; set; }

    public string CTitle { get; set; }

    public DateTime? CPickupDate { get; set; }

    public string CShipper { get; set; }

    public string CCdcTag { get; set; }

    public DateTime? CShippingDateTo { get; set; }

    public string CNote { get; set; }

    public virtual WmsInvLocation CDropLocationPkNavigation { get; set; }

    public virtual ICollection<WmsInvPickDetail> WmsInvPickDetails { get; set; } = new List<WmsInvPickDetail>();

    public virtual ICollection<WmsInvPickOrderPosition> WmsInvPickOrderPositions { get; set; } = new List<WmsInvPickOrderPosition>();
}
