using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComLocationType
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public string CType { get; set; }

    public int? CWidth { get; set; }

    public virtual ICollection<ComLocation> ComLocations { get; set; } = new List<ComLocation>();

    public virtual ICollection<ComTypePlacingRule> ComTypePlacingRules { get; set; } = new List<ComTypePlacingRule>();
}
