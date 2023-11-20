using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComAccount
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public bool CDefault { get; set; }

    public string CIdentifier { get; set; }

    public string CName { get; set; }

    public virtual ICollection<ComLocationGroup> ComLocationGroups { get; set; } = new List<ComLocationGroup>();

    public virtual ICollection<ComLocation> ComLocations { get; set; } = new List<ComLocation>();
}
