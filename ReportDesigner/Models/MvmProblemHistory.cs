using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class MvmProblemHistory
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CMessage { get; set; }

    public string CNo { get; set; }

    public DateTime? COccurred { get; set; }

    public long? CFkMovement { get; set; }

    public virtual MvmMovement CFkMovementNavigation { get; set; }
}
