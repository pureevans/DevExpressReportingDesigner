using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickDetail
{
    public long COrderPk { get; set; }

    public string CValue { get; set; }

    public string CKey { get; set; }

    public virtual WmsInvPickOrder COrderPkNavigation { get; set; }
}
