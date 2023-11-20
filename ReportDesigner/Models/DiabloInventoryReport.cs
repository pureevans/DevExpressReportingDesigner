using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class DiabloInventoryReport
{
    public string CErpCode { get; set; }

    public string CDescription { get; set; }

    public bool? COutgoingActive { get; set; }

    public bool? CIncomingActive { get; set; }

    public bool? CMixedProducts { get; set; }

    public int? CNoMaxTransportUnits { get; set; }

    public int? CPlcState { get; set; }

    public string Parentlocation { get; set; }

    public string Inventorystate { get; set; }

    public DateTime? CStartedAt { get; set; }

    public DateTime? CFinishedAt { get; set; }

    public string Countedtu { get; set; }

    public string CSku { get; set; }

    public DateTime? CCountedAt { get; set; }

    public string CCountedBy { get; set; }

    public int? CQtyCounted { get; set; }

    public int? CQtyExpected { get; set; }

    public int? Difference { get; set; }

    public string Locationgroup { get; set; }

    public string CCountType { get; set; }
}
