using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComSrvRevision
{
    public long CPk { get; set; }

    public long? CTimestamp { get; set; }

    public string CUser { get; set; }

    public string CTraceId { get; set; }
}
