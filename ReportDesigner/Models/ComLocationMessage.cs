using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComLocationMessage
{
    public long CLocationId { get; set; }

    public long CMessageId { get; set; }

    public virtual ComLocation CLocation { get; set; }

    public virtual CorMessage CMessage { get; set; }
}
