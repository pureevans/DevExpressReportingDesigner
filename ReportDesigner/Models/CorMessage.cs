using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorMessage
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public int? CMessageNo { get; set; }

    public string CMessageText { get; set; }

    public virtual ComLocationMessage ComLocationMessage { get; set; }
}
