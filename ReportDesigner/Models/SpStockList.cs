using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpStockList
{
    public string CSku { get; set; }

    public string CTransportUnitBk { get; set; }

    public string CDescription { get; set; }

    public string Tustate { get; set; }

    public int? Stock { get; set; }

    public string Location { get; set; }

    public int? Locationstate { get; set; }

    public string Locationdesc { get; set; }

    public string Locationgrouploc { get; set; }

    public string Locationgroup { get; set; }

    public int? Isdispo { get; set; }
}
