using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvPickOrderPosReference
{
    public long CPk { get; set; }

    public long CPickOrderPk { get; set; }

    public long CPickOrderPosPk { get; set; }

    public long CShpOrderPk { get; set; }

    public long? CShpOrderPosPk { get; set; }

    public bool CConfirmed { get; set; }
}
