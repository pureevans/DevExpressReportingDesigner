using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProductStackingRule
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public int CNoProducts { get; set; }

    public long CAllowedProduct { get; set; }

    public long CBaseProduct { get; set; }

    public virtual WmsInvProduct CAllowedProductNavigation { get; set; }

    public virtual WmsInvProduct CBaseProductNavigation { get; set; }
}
