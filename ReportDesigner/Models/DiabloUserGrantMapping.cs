using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class DiabloUserGrantMapping
{
    public int CId { get; set; }

    public int CUserId { get; set; }

    public int CGrantId { get; set; }

    public virtual DiabloUserGrant CGrant { get; set; }

    public virtual DiabloUser CUser { get; set; }
}
