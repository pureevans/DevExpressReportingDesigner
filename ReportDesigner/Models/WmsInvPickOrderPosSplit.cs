using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderPosSplit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CLoadUnitPos { get; set; }

    public string COrderRef { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public string CQtyTypePick { get; set; }

    public int? CQtyPosPick { get; set; }

    public int? CQtyToPick { get; set; }

    public int CQtyPicked { get; set; }

    public string CQtyTypeReserved { get; set; }

    public int? CQtyReserved { get; set; }

    public int CSplitNo { get; set; }

    public string CState { get; set; }

    public long? CFromTransportunitPk { get; set; }

    public long? CLocationPk { get; set; }

    public long CPositionPk { get; set; }

    public long? CToTransportunitPk { get; set; }

    public int CProdutctPk { get; set; }

    public long? CShpOrderPk { get; set; }

    public long? CShpOrderPosPk { get; set; }

    public virtual WmsInvTransportUnit CFromTransportunitPkNavigation { get; set; }

    public virtual WmsInvLocation CLocationPkNavigation { get; set; }

    public virtual WmsInvPickOrderPosition CPositionPkNavigation { get; set; }

    public virtual WmsInvTransportUnit CToTransportunitPkNavigation { get; set; }
}
