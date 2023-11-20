using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorPrtReportJob
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public int? CState { get; set; }

    public string CData { get; set; }

    public string CMediaType { get; set; }

    public string COutputFormat { get; set; }

    public string CParameter { get; set; }

    public string CReportContentRef { get; set; }

    public string CTemplateName { get; set; }

    public string CTenant { get; set; }
}
