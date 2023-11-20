using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsRecOrderPostionErp
{
    public int CId { get; set; }

    public string COrderId { get; set; }

    public int CPosNo { get; set; }

    public string CSku { get; set; }

    public int CQtyReceived { get; set; }

    public bool CErpSubmitted { get; set; }

    public int CErpType { get; set; }
}
