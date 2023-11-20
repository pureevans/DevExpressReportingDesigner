using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProductUnit
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public int? CHeight { get; set; }

    public int? CLength { get; set; }

    public string CUom { get; set; }

    public int? CWidth { get; set; }

    public string CLabel { get; set; }

    public string CQtyType { get; set; }

    public string CQty { get; set; }

    public long CProductPk { get; set; }

    public virtual WmsInvProduct CProductPkNavigation { get; set; }

    public virtual ICollection<WmsInvProductUnitDetail> WmsInvProductUnitDetails { get; set; } = new List<WmsInvProductUnitDetail>();
}
