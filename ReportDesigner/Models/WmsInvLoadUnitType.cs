using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvLoadUnitType
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public int? CInnerHeight { get; set; }

    public int? CInnerLength { get; set; }

    public int? CInnerWidth { get; set; }

    public int? COuterHeight { get; set; }

    public int? COuterLength { get; set; }

    public int? COuterWidth { get; set; }

    public string CType { get; set; }

    public string CWeightMaxType { get; set; }

    public string CWeightMax { get; set; }

    public string CWeightTareType { get; set; }

    public string CWeightTare { get; set; }

    public virtual ICollection<WmsInvLoadUnit> WmsInvLoadUnits { get; set; } = new List<WmsInvLoadUnit>();
}
