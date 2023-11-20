using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsRecOrderDetail
{
    public long COrderPk { get; set; }

    public string CValue { get; set; }

    public string CKey { get; set; }

    public virtual WmsRecOrder COrderPkNavigation { get; set; }
}
