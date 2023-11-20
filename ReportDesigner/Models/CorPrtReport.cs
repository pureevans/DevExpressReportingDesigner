using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorPrtReport
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CContent { get; set; }

    public string CName { get; set; }

    public string CMediaType { get; set; }

    public string CTenant { get; set; }
}
