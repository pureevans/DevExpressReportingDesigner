using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderPosSplitLog
{
    public long CPk { get; set; }

    public long CRev { get; set; }

    public short? CRevType { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public string CPid { get; set; }

    public string CLoadUnitPos { get; set; }

    public string COrderRef { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public string CQtyTypePick { get; set; }

    public string CQtyPick { get; set; }

    public string CQtyTypeReserved { get; set; }

    public string CQtyReserved { get; set; }

    public string CReservationId { get; set; }

    public int? CSplitNo { get; set; }

    public string CState { get; set; }

    public string CToLoadUnitPos { get; set; }

    public long? CFromTransportunitPk { get; set; }

    public long? CListPositionPk { get; set; }

    public long? CLocationPk { get; set; }

    public long? CPositionPk { get; set; }

    public long? CToTransportunitPk { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
