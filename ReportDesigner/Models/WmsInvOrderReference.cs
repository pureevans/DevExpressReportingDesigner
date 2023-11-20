using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvOrderReference
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CForeignId { get; set; }

    public long? CPopPk { get; set; }

    public bool CConfirmed { get; set; }

    public virtual WmsInvPickOrderPosition CPopPkNavigation { get; set; }
}
