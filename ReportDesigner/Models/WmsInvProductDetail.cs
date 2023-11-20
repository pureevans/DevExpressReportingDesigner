using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProductDetail
{
    public long CProductPk { get; set; }

    public string CValue { get; set; }

    public string CKey { get; set; }

    public virtual WmsInvProduct CProductPkNavigation { get; set; }
}
