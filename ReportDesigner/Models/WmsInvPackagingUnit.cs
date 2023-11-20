﻿using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPackagingUnit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CAvState { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public string CUom { get; set; }

    public int? CWidth { get; set; }

    public DateTime? CFifoDate { get; set; }

    public string CLabels { get; set; }

    public string CLotPkey { get; set; }

    public int? CMessageNo { get; set; }

    public string CMessageText { get; set; }

    public string PhysicalPosition { get; set; }

    public string CQtyType { get; set; }

    public int CQty { get; set; }

    public string CSerialNumber { get; set; }

    public string CWeightType { get; set; }

    public string CWeight { get; set; }

    public long? CActualLocation { get; set; }

    public long? CLoadUnit { get; set; }

    public long? CParent { get; set; }

    public long? CProductPk { get; set; }

    public DateTime? CExpiresAt { get; set; }

    public string CPhysicalPos { get; set; }

    public bool? CAlive { get; set; }

    public string CLotId { get; set; }

    public virtual WmsInvLocation CActualLocationNavigation { get; set; }

    public virtual WmsInvLoadUnit CLoadUnitNavigation { get; set; }

    public virtual WmsInvPackagingUnit CParentNavigation { get; set; }

    public virtual WmsInvProduct CProductPkNavigation { get; set; }

    public virtual ICollection<WmsInvPackagingUnit> InverseCParentNavigation { get; set; } = new List<WmsInvPackagingUnit>();

    public virtual ICollection<WmsInvReservation> WmsInvReservations { get; set; } = new List<WmsInvReservation>();
}
