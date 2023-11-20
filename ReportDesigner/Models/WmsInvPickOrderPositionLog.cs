using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderPositionLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public string CUser { get; set; }

    public string CCustomerOrderId { get; set; }

    public DateTime? CLatestDue { get; set; }

    public DateTime? CNextAllocation { get; set; }

    public string COrderRef { get; set; }

    public int? CPositionId { get; set; }

    public int? CPriority { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public string CQtyTypePick { get; set; }

    public string CQtyPick { get; set; }

    public string CSourceLocationGroups { get; set; }

    public string CState { get; set; }

    public string CType { get; set; }

    public long? COrderPk { get; set; }

    public long? CProductPk { get; set; }

    public string CQtyTypeOnError { get; set; }

    public string CQtyOnError { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
