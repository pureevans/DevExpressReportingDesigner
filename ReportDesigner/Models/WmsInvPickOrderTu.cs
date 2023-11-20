using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderTu
{
    public long CPk { get; set; }

    public long CTuPk { get; set; }

    public virtual WmsInvPickOrder CPkNavigation { get; set; }

    public virtual WmsInvTransportUnit CTuPkNavigation { get; set; }
}
