using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComLocation
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CCheckState { get; set; }

    public string CClassification { get; set; }

    public bool? CConsideredInAllocation { get; set; }

    public bool? CCountingActive { get; set; }

    public string CDescription { get; set; }

    public bool? CDirectBookingAllowed { get; set; }

    public string CErpCode { get; set; }

    public string CGroup { get; set; }

    public bool? CIncomingActive { get; set; }

    public string CLabels { get; set; }

    public DateTime? CLastMovement { get; set; }

    public bool? CLgCountingActive { get; set; }

    public string CAisle { get; set; }

    public string CArea { get; set; }

    public string CX { get; set; }

    public string CY { get; set; }

    public string CZ { get; set; }

    public decimal? CMaximumWeight { get; set; }

    public int? CNoMaxTransportUnits { get; set; }

    public bool? COutgoingActive { get; set; }

    public string CPlcCode { get; set; }

    public int? CPlcState { get; set; }

    public string CStockZone { get; set; }

    public string CAccount { get; set; }

    public long? CLocationGroup { get; set; }

    public long? CLocationType { get; set; }

    public int? CSort { get; set; }

    public virtual ComAccount CAccountNavigation { get; set; }

    public virtual ComLocationGroup CLocationGroupNavigation { get; set; }

    public virtual ComLocationType CLocationTypeNavigation { get; set; }

    public virtual ICollection<ComLocationMessage> ComLocationMessages { get; set; } = new List<ComLocationMessage>();

    public virtual ICollection<ComTransportUnit> ComTransportUnitCActualLocationNavigations { get; set; } = new List<ComTransportUnit>();

    public virtual ICollection<ComTransportUnit> ComTransportUnitCTargetLocationNavigations { get; set; } = new List<ComTransportUnit>();
}
