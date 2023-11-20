using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class TempReport
{
    public DateTime? CDate { get; set; }

    public string COp { get; set; }

    public double? CQty { get; set; }

    public string CSku { get; set; }

    public string CTu { get; set; }

    public string CErpCode { get; set; }

    public string CDesc { get; set; }
}
