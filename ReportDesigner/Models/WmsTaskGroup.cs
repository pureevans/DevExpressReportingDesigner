using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsTaskGroup
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public string CName { get; set; }

    public virtual ICollection<WmsTaskReconciliation> WmsTaskReconciliations { get; set; } = new List<WmsTaskReconciliation>();
}
