using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorPrtPrintJob
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public int? CState { get; set; }

    public int? CCopies { get; set; }

    public string CDevice { get; set; }

    public string CMediaSize { get; set; }

    public string CReportRef { get; set; }
}
