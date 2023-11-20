using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComTransaction
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CCreatedByUser { get; set; }

    public string CDescription { get; set; }

    public string CSender { get; set; }

    public string CType { get; set; }

    public string CCategory { get; set; }

    public string CSenderId { get; set; }

    public string CTraceId { get; set; }
}
