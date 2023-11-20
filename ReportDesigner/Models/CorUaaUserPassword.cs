using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorUaaUserPassword
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPassword { get; set; }

    public DateTime? CPasswordChanged { get; set; }

    public string CUsername { get; set; }

    public virtual CorUaaUser CUsernameNavigation { get; set; }
}
