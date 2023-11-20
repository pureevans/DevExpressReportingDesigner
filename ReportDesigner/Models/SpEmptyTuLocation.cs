using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpEmptyTuLocation
{
    public string Locationdesc { get; set; }

    public string Locationgrouploc { get; set; }

    public string MainLocationGroup { get; set; }

    public int? Isdispo { get; set; }

    public int CNoMaxTransportUnits { get; set; }

    public string CErpCode { get; set; }

    public bool CNoInboundMovement { get; set; }

    public bool CMovementTarget { get; set; }
}
