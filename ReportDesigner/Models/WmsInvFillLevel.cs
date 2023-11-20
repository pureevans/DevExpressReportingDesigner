using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvFillLevel
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CAccount { get; set; }

    public string CAvState { get; set; }

    public string CQtyTypeMax { get; set; }

    public string CQtyMax { get; set; }

    public string CQtyTypeMin { get; set; }

    public string CQtyMin { get; set; }

    public string CSourceLocationGroups { get; set; }

    public long CLocationPk { get; set; }

    public virtual WmsInvLocation CLocationPkNavigation { get; set; }
}
