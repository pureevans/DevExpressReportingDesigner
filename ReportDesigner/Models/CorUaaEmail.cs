using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorUaaEmail
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CAddress { get; set; }

    public string CFullName { get; set; }

    public bool CPrimary { get; set; }

    public string CUsername { get; set; }

    public virtual CorUaaUser CUsernameNavigation { get; set; }
}
