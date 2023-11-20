using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorPrtPrinter
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string Barcode { get; set; }

    public decimal? ClientGroup { get; set; }

    public string ClientName { get; set; }

    public string Description { get; set; }

    public string IpAddr { get; set; }

    public string Name { get; set; }

    public string PortNo { get; set; }

    public long PrinterId { get; set; }

    public string RemotePassword { get; set; }

    public string RemoteUser { get; set; }

    public string Subtype { get; set; }

    public string Type { get; set; }
}
