using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class MvmMovementGroup
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CUser { get; set; }

    public string CName { get; set; }

    public string CState { get; set; }

    public virtual ICollection<MvmMovement> MvmMovements { get; set; } = new List<MvmMovement>();
}
