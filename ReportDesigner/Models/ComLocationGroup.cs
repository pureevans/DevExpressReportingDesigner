using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class ComLocationGroup
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CDescription { get; set; }

    public string CGroupStateIn { get; set; }

    public string CGroupStateOut { get; set; }

    public string CGroupType { get; set; }

    public bool? CGroupCountingActive { get; set; }

    public float? CMaxFillLevel { get; set; }

    public string CName { get; set; }

    public string COpMode { get; set; }

    public string CSystemCode { get; set; }

    public string CSystemName { get; set; }

    public string CAccount { get; set; }

    public long? CParent { get; set; }

    public long? CInLocker { get; set; }

    public long? COutLocker { get; set; }

    public bool? CReorg { get; set; }

    public bool CIsExternal { get; set; }

    public string CName1 { get; set; }

    public string CName2 { get; set; }

    public string CStreet1 { get; set; }

    public string CStreet2 { get; set; }

    public string CPostalCode { get; set; }

    public string CCity { get; set; }

    public string CCountry { get; set; }

    public string CPhoneNumber { get; set; }

    public string CEmail { get; set; }

    public virtual ComAccount CAccountNavigation { get; set; }

    public virtual ComLocationGroup CInLockerNavigation { get; set; }

    public virtual ComLocationGroup COutLockerNavigation { get; set; }

    public virtual ComLocationGroup CParentNavigation { get; set; }

    public virtual ICollection<ComLocation> ComLocations { get; set; } = new List<ComLocation>();

    public virtual ICollection<ComLocationGroup> InverseCInLockerNavigation { get; set; } = new List<ComLocationGroup>();

    public virtual ICollection<ComLocationGroup> InverseCOutLockerNavigation { get; set; } = new List<ComLocationGroup>();

    public virtual ICollection<ComLocationGroup> InverseCParentNavigation { get; set; } = new List<ComLocationGroup>();
}
