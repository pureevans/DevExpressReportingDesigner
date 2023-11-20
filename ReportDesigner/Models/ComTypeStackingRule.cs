using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComTypeStackingRule
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public int CNoTransportUnits { get; set; }

    public long CAllowedTransportUnitType { get; set; }

    public long? CTransportUnitType { get; set; }

    public virtual ComTransportUnitType CAllowedTransportUnitTypeNavigation { get; set; }

    public virtual ComTransportUnitType CTransportUnitTypeNavigation { get; set; }
}
