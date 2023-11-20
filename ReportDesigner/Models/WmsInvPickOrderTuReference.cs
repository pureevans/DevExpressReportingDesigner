using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderTuReference
{
    public int CPk { get; set; }

    public long CTranportUnitPk { get; set; }

    public bool CConfirmed { get; set; }

    public long CPickOrderPk { get; set; }

    public long CShpOrderPk { get; set; }

    public bool CFull { get; set; }
}
