using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsRecProduct
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CBaseUnitType { get; set; }

    public string CBaseUnitQty { get; set; }

    public string CDescription { get; set; }

    public string CForeignPid { get; set; }

    public string CLabel { get; set; }

    public string CSku { get; set; }
}
