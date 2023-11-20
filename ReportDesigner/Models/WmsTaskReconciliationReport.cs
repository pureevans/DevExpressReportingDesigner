using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsTaskReconciliationReport
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime CCountedAt { get; set; }

    public string CCountedBy { get; set; }

    public DateTime? CProcessedAt { get; set; }

    public string CDescription { get; set; }

    public string CForeignPkey { get; set; }

    public string CLabel { get; set; }

    public string CSku { get; set; }

    public string CQtyCountedType { get; set; }

    public int CQtyCounted { get; set; }

    public string CTransportUnitBk { get; set; }

    public string CCountType { get; set; }

    public long? CTask { get; set; }

    public string CMessage { get; set; }

    public string CReconciliationReason { get; set; }

    public int CQtyExpected { get; set; }

    public virtual WmsTaskReconciliation CTaskNavigation { get; set; }
}
