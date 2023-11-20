using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class Temptable
{
    public string Erpcode { get; set; }

    public int? Sortindex { get; set; }

    public bool? Processed { get; set; }
}
