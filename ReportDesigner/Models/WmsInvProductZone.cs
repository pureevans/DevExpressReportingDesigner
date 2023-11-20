﻿using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProductZone
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CLocationGroupName { get; set; }

    public int? CPosition { get; set; }

    public long? CProductPk { get; set; }

    public virtual WmsInvProduct CProductPkNavigation { get; set; }
}
