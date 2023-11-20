using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorUaaRole
{
    public string CType { get; set; }

    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public string CName { get; set; }

    public bool? CImmutable { get; set; }

    public virtual ICollection<CorUaaRole> CGrants { get; set; } = new List<CorUaaRole>();

    public virtual ICollection<CorUaaRole> CRoles { get; set; } = new List<CorUaaRole>();

    public virtual ICollection<CorUaaUser> CUsers { get; set; } = new List<CorUaaUser>();
}
