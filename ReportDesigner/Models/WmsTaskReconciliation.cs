using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsTaskReconciliation
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime? CAssignedAt { get; set; }

    public string CAssignedTo { get; set; }

    public string CDescription { get; set; }

    public DateTime? CFinishedAt { get; set; }

    public bool? CDirectBookingAllowed { get; set; }

    public string CErpCode { get; set; }

    public string CLocationGroupName { get; set; }

    public string CFromTransportUnitBk { get; set; }

    public DateTime? CStartedAt { get; set; }

    public string CState { get; set; }

    public string CTaskId { get; set; }

    public string CType { get; set; }

    public long? CParentTask { get; set; }

    public long? CTaskGroup { get; set; }

    public bool? CMixedProducts { get; set; }

    public virtual WmsTaskReconciliation CParentTaskNavigation { get; set; }

    public virtual WmsTaskGroup CTaskGroupNavigation { get; set; }

    public virtual ICollection<WmsTaskReconciliation> InverseCParentTaskNavigation { get; set; } = new List<WmsTaskReconciliation>();

    public virtual ICollection<WmsTaskReconciliationReport> WmsTaskReconciliationReports { get; set; } = new List<WmsTaskReconciliationReport>();
}
