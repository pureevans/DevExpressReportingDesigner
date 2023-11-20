using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComTypePlacingRule
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public int CPrivilegeLevel { get; set; }

    public long CAllowedLocationType { get; set; }

    public long CTutId { get; set; }

    public virtual ComLocationType CAllowedLocationTypeNavigation { get; set; }

    public virtual ComTransportUnitType CTut { get; set; }
}
