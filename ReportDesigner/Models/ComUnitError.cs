using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComUnitError
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CErrorNo { get; set; }

    public string CErrorText { get; set; }

    public long CTuId { get; set; }

    public virtual ComTransportUnit CTu { get; set; }
}
