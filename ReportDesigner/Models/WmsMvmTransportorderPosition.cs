using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsMvmTransportorderPosition
{
    public long CPk { get; set; }

    public DateTime CCreated { get; set; }

    public DateTime CUpdated { get; set; }

    public string COrderState { get; set; }

    public int CPositionNo { get; set; }

    public string CProblemMessage { get; set; }

    public int CQtyOrdered { get; set; }

    public string COrderId { get; set; }

    public long CProductPk { get; set; }

    public int CQtyShipped { get; set; }

    public long CTransportorderPk { get; set; }

    public string CMessage { get; set; }

    public virtual WmsMvmTransportorder CTransportorderPkNavigation { get; set; }
}
