﻿using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComTransportUnit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public DateTime? CActualLocationDate { get; set; }

    public string CBarcode { get; set; }

    public bool? CEmpty { get; set; }

    public string CGroupId { get; set; }

    public DateTime? CInventoryDate { get; set; }

    public string CInventoryUser { get; set; }

    public string CState { get; set; }

    public decimal? CWeight { get; set; }

    public int? CWeightUom { get; set; }

    public long CActualLocation { get; set; }

    public long? CParent { get; set; }

    public long? CTargetLocation { get; set; }

    public long CTransportUnitType { get; set; }

    public virtual ComLocation CActualLocationNavigation { get; set; }

    public virtual ComTransportUnit CParentNavigation { get; set; }

    public virtual ComLocation CTargetLocationNavigation { get; set; }

    public virtual ComTransportUnitType CTransportUnitTypeNavigation { get; set; }

    public virtual ICollection<ComUnitError> ComUnitErrors { get; set; } = new List<ComUnitError>();

    public virtual ICollection<ComTransportUnit> InverseCParentNavigation { get; set; } = new List<ComTransportUnit>();
}
