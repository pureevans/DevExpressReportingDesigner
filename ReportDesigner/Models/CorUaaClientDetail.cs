using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class CorUaaClientDetail
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public int? CAccessTokenValidity { get; set; }

    public string CAdditionalInformation { get; set; }

    public string CAuthorities { get; set; }

    public string CAuthorizedGrantTypes { get; set; }

    public string CAutoapprove { get; set; }

    public string CClientId { get; set; }

    public string CClientSecret { get; set; }

    public int? CRefreshTokenValidity { get; set; }

    public string CResourceIds { get; set; }

    public string CScope { get; set; }

    public string CWebServerRedirectUri { get; set; }
}
