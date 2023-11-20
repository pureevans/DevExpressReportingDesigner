using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class DiabloUser
{
    public int CId { get; set; }

    public DateTime CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public bool CEnabled { get; set; }

    public bool CExtern { get; set; }

    public string CUsername { get; set; }

    public string CFullname { get; set; }

    public DateTime? CLastPasswortChange { get; set; }

    public string CPassword { get; set; }

    public string CDepartment { get; set; }

    public string CPrinterList { get; set; }

    public string CPrinterLabel { get; set; }

    public string CSelectedWarehouse { get; set; }

    public string CCaddy { get; set; }

    public string CSalt { get; set; }

    public string CSelectedShipper { get; set; }

    public bool CCanReopenShippingOrder { get; set; }

    public bool CResetPrinter { get; set; }

    public virtual ICollection<DiabloUserGrantMapping> DiabloUserGrantMappings { get; set; } = new List<DiabloUserGrantMapping>();
}
