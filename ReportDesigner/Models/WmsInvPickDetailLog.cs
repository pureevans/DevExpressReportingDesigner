using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickDetailLog
{
    public long CRev { get; set; }

    public long COrderPk { get; set; }

    public string CValue { get; set; }

    public string CKey { get; set; }

    public short? CRevType { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
