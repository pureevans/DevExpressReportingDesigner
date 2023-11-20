using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsShpOrderPositionSplit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CLoadUnitPkey { get; set; }

    public int? CPriority { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public string CQuantityType { get; set; }

    public string CQty { get; set; }

    public string CReservationId { get; set; }

    public int CSplitNo { get; set; }

    public string CStartMode { get; set; }

    public string CTargetName { get; set; }

    public string CTargetType { get; set; }

    public string CTransportUnitBk { get; set; }

    public long CPositionPk { get; set; }

    public long? CProductPk { get; set; }

    public virtual WmsShpOrderPosition CPositionPkNavigation { get; set; }

    public virtual WmsShpProduct CProductPkNavigation { get; set; }
}
