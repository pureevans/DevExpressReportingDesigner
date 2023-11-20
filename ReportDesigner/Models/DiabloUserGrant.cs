using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class DiabloUserGrant
{
    public int CId { get; set; }

    public DateTime CCreated { get; set; }

    public string CDescription { get; set; }

    public string CName { get; set; }

    public string CApplication { get; set; }

    public virtual ICollection<DiabloUserGrantMapping> DiabloUserGrantMappings { get; set; } = new List<DiabloUserGrantMapping>();
}
