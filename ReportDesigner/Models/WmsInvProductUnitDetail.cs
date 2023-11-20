using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProductUnitDetail
{
    public long CProductUnitPk { get; set; }

    public string CValue { get; set; }

    public string CKey { get; set; }

    public virtual WmsInvProductUnit CProductUnitPkNavigation { get; set; }
}
