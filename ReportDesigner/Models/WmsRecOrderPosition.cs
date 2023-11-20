using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsRecOrderPosition
{
    public string CDisc { get; set; }

    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public DateTime? CLatestDue { get; set; }

    public int CPosNo { get; set; }

    public string CState { get; set; }

    public string CQtyExpectedType { get; set; }

    public int? CQtyExpected { get; set; }

    public string CQtyReceivedType { get; set; }

    public int? CQtyReceived { get; set; }

    public string CTransportUnitBk { get; set; }

    public string CTransportUnitTypeName { get; set; }

    public string COrderId { get; set; }

    public string CSku { get; set; }

    public int? CTargetLocation { get; set; }

    public int CQtyTuAktion { get; set; }

    public string CCustomerOrderId { get; set; }

    public string CTargetLocationGroup { get; set; }

    public string CSourceLocationGroup { get; set; }

    public long? CMvmTransportorderPosId { get; set; }

    public virtual WmsRecOrder COrder { get; set; }
}
