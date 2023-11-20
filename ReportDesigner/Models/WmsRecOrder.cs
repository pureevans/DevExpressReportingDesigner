using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsRecOrder
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime? CStartEarliest { get; set; }

    public DateTime? CEndDate { get; set; }

    public DateTime? CExpectedReceipt { get; set; }

    public DateTime? CLatestDue { get; set; }

    public bool? CLocked { get; set; }

    public DateTime? CNextAlloc { get; set; }

    public string COrderId { get; set; }

    public string COrderState { get; set; }

    public int? CPriority { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public DateTime? CStartDate { get; set; }

    public string CSupplierNumber { get; set; }

    public string CContainerNumber { get; set; }

    public string CLocationGroup { get; set; }

    public bool? CExternalConfirmed { get; set; }

    public long? CMvmTransportorderPk { get; set; }

    public virtual ICollection<WmsRecOrderDetail> WmsRecOrderDetails { get; set; } = new List<WmsRecOrderDetail>();

    public virtual ICollection<WmsRecOrderPosition> WmsRecOrderPositions { get; set; } = new List<WmsRecOrderPosition>();
}
