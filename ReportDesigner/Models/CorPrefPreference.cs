using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorPrefPreference
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDefValue { get; set; }

    public string CDescription { get; set; }

    public bool? CFromFile { get; set; }

    public string CKey { get; set; }

    public string CMaxValue { get; set; }

    public string CMinValue { get; set; }

    public string COwner { get; set; }

    public string CScope { get; set; }

    public string CType { get; set; }

    public string CCurrentValue { get; set; }
}
