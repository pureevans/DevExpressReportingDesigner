using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsShpProductDetail
{
    public long CProductPk { get; set; }

    public string CValue { get; set; }

    public string CKey { get; set; }

    public virtual WmsShpProduct CProductPkNavigation { get; set; }
}
