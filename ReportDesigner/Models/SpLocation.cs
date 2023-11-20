using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpLocation
{
    public string CErpCode { get; set; }

    public string CDescription { get; set; }

    public bool? COutgoingActive { get; set; }

    public bool? CIncomingActive { get; set; }

    public bool? CMixedProducts { get; set; }

    public int? CNoMaxTransportUnits { get; set; }

    public int? CPlcState { get; set; }

    public DateTime? CLastInventoryDate { get; set; }

    public string Locationgroup { get; set; }

    public string CLocationGroup { get; set; }

    public int? CSort { get; set; }

    public int? CSplsDispo { get; set; }

    public int CSingleMaxTransportUnits { get; set; }

    public int CLocationType { get; set; }

    public bool? CDirectBookingAllowed { get; set; }

    public bool CNoInboundMovement { get; set; }

    public bool CMovementTarget { get; set; }

    public bool CIsReceivingLocation { get; set; }

    public bool CIsActiveLocation { get; set; }
}
