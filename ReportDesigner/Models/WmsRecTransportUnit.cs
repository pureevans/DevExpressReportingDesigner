using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsRecTransportUnit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CActualLocation { get; set; }

    public string CBarcode { get; set; }

    public string CForeignPid { get; set; }
}
