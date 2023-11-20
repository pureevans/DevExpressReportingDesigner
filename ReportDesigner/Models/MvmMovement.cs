using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class MvmMovement
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime? CEndDate { get; set; }

    public DateTime? CLatestDue { get; set; }

    public string CMessage { get; set; }

    public string CNo { get; set; }

    public DateTime? COccurred { get; set; }

    public string CMode { get; set; }

    public string CPriority { get; set; }

    public string CSourceLocation { get; set; }

    public string CSourceLocationGroupName { get; set; }

    public DateTime? CStartDate { get; set; }

    public DateTime? CStartEarliestDate { get; set; }

    public string CState { get; set; }

    public string CTargetLocation { get; set; }

    public string CTargetLocationGroupName { get; set; }

    public string CTransportUnitBk { get; set; }

    public string CType { get; set; }

    public long? CGroupPk { get; set; }

    public string CSku { get; set; }

    public string CInitiator { get; set; }

    public long? CReceivingOrderPositionId { get; set; }

    public int? CQty { get; set; }

    public long? CPickorderPosId { get; set; }

    public long? CMvmTransportorderPosId { get; set; }

    public virtual MvmMovementGroup CGroupPkNavigation { get; set; }

    public virtual ICollection<MvmProblemHistory> MvmProblemHistories { get; set; } = new List<MvmProblemHistory>();
}
