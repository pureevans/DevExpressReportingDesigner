using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsShpProduct
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public string CForeignPid { get; set; }

    public string CLabel { get; set; }

    public string CSku { get; set; }

    public string CStockZone { get; set; }

    public virtual ICollection<WmsShpOrderPositionSplit> WmsShpOrderPositionSplits { get; set; } = new List<WmsShpOrderPositionSplit>();

    public virtual ICollection<WmsShpProductDetail> WmsShpProductDetails { get; set; } = new List<WmsShpProductDetail>();
}
