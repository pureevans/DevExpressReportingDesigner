using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderTuLog
{
    public long CRev { get; set; }

    public long CPk { get; set; }

    public long CTuPk { get; set; }

    public short? CRevType { get; set; }

    public virtual WmsInvRevision CRevNavigation { get; set; }
}
