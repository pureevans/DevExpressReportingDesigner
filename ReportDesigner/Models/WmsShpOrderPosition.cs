using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsShpOrderPosition
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime? CStartEarliest { get; set; }

    public DateTime? CLatestDue { get; set; }

    public bool? CLocked { get; set; }

    public DateTime? CNextAllocation { get; set; }

    public string COrderState { get; set; }

    public int CPositionNo { get; set; }

    public int? CPriority { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public string CQtyTypeAlloc { get; set; }

    public int? CQtyAlloc { get; set; }

    public string CQtyTypeCrossdock { get; set; }

    public string CQtyCrossdock { get; set; }

    public string CQtyTypeOrdered { get; set; }

    public int CQtyOrdered { get; set; }

    public string CSourceLocationGroups { get; set; }

    public string CToStartMode { get; set; }

    public string CTargetName { get; set; }

    public string CTargetType { get; set; }

    public string COrderId { get; set; }

    public long CProductPk { get; set; }

    public string CAssignedUser { get; set; }

    public int CQtyShipped { get; set; }

    public long? CMvmTransportorderPosId { get; set; }

    public long CErpPositionId { get; set; }

    public virtual WmsShpOrder COrder { get; set; }

    public virtual ICollection<WmsShpOrderPositionSplit> WmsShpOrderPositionSplits { get; set; } = new List<WmsShpOrderPositionSplit>();
}
