using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvTransportUnit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public bool? CAcknowledged { get; set; }

    public DateTime? CActualLocationDate { get; set; }

    public string CCustomerOrderId { get; set; }

    public string CForeignPid { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public string CState { get; set; }

    public string CTarget { get; set; }

    public string CTransportUnitBk { get; set; }

    public string CTransportUnitType { get; set; }

    public int? CWidth { get; set; }

    public long CActualLocation { get; set; }

    public DateTime? CReconciledAt { get; set; }

    public string CReconciledBy { get; set; }

    public string CErpOrderSourceId { get; set; }

    public bool CAddWeight { get; set; }

    public long? CMvmTransportorderPosId { get; set; }

    public virtual WmsInvLocation CActualLocationNavigation { get; set; }

    public virtual ICollection<WmsInvLoadUnit> WmsInvLoadUnits { get; set; } = new List<WmsInvLoadUnit>();

    public virtual ICollection<WmsInvPickOrderPosSplit> WmsInvPickOrderPosSplitCFromTransportunitPkNavigations { get; set; } = new List<WmsInvPickOrderPosSplit>();

    public virtual ICollection<WmsInvPickOrderPosSplit> WmsInvPickOrderPosSplitCToTransportunitPkNavigations { get; set; } = new List<WmsInvPickOrderPosSplit>();
}
