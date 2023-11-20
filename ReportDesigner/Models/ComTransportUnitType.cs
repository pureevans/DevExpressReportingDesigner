using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComTransportUnitType
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CCompatibility { get; set; }

    public string CDescription { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public decimal? CPayload { get; set; }

    public string CType { get; set; }

    public decimal? CWeightMax { get; set; }

    public decimal? CWeightTare { get; set; }

    public int? CWidth { get; set; }

    public bool CShipment { get; set; }

    public bool CAddWeight { get; set; }

    public int CSequence { get; set; }

    public virtual ICollection<ComTransportUnit> ComTransportUnits { get; set; } = new List<ComTransportUnit>();

    public virtual ICollection<ComTypePlacingRule> ComTypePlacingRules { get; set; } = new List<ComTypePlacingRule>();

    public virtual ICollection<ComTypeStackingRule> ComTypeStackingRuleCAllowedTransportUnitTypeNavigations { get; set; } = new List<ComTypeStackingRule>();

    public virtual ICollection<ComTypeStackingRule> ComTypeStackingRuleCTransportUnitTypeNavigations { get; set; } = new List<ComTypeStackingRule>();
}
