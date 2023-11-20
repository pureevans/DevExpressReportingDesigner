using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsReport
{
    public int CId { get; set; }

    public string CReportName { get; set; }

    public byte[] CReportLayoutData { get; set; }

    public string CReportJsonScheme { get; set; }
}
