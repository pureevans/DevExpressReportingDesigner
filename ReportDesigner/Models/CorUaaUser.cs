using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorUaaUser
{
    public string CType { get; set; }

    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public bool? CEnabled { get; set; }

    public DateTime? CExpirationDate { get; set; }

    public bool? CExtern { get; set; }

    public string CFullname { get; set; }

    public DateTime? CLastPasswordChange { get; set; }

    public bool? CLocked { get; set; }

    public string CPassword { get; set; }

    public string CComment { get; set; }

    public string CDepartment { get; set; }

    public string CDescription { get; set; }

    public string CGender { get; set; }

    public string CIm { get; set; }

    public long? CImage { get; set; }

    public string COffice { get; set; }

    public string CPhoneNo { get; set; }

    public string CUsername { get; set; }

    public string CSalt { get; set; }

    public virtual ICollection<CorUaaEmail> CorUaaEmails { get; set; } = new List<CorUaaEmail>();

    public virtual ICollection<CorUaaUserPassword> CorUaaUserPasswords { get; set; } = new List<CorUaaUserPassword>();

    public virtual ICollection<CorUaaRole> CRoles { get; set; } = new List<CorUaaRole>();
}
