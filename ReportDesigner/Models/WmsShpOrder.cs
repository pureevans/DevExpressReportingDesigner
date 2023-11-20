using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsShpOrder
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CCustomerNo { get; set; }

    public DateTime? CLatestDue { get; set; }

    public bool? CLocked { get; set; }

    public DateTime? CNextAllocation { get; set; }

    public string COrderId { get; set; }

    public string COrderState { get; set; }

    public int? CPriority { get; set; }

    public string CProblemMessage { get; set; }

    public int? CProblemMessageNo { get; set; }

    public DateTime? CProblemOccurred { get; set; }

    public string CType { get; set; }

    public DateTime? CStartDate { get; set; }

    public string CStartMode { get; set; }

    public string CCdcTag { get; set; }

    public string CCountry { get; set; }

    public string CCustomerGroup { get; set; }

    public string CCustomerName { get; set; }

    public string COrderType { get; set; }

    public string CShipper { get; set; }

    public DateTime? CShippingDateTo { get; set; }

    public DateTime? CShippingDateFrom { get; set; }

    public string CWeight { get; set; }

    public string CMyfactoryOrderNumber { get; set; }

    public string COrderSource { get; set; }

    public string CTitle { get; set; }

    public DateTime? CPickUpDate { get; set; }

    public string CLocationGroup { get; set; }

    public bool? CExternalConfirmed { get; set; }

    public string CErpOrderId { get; set; }

    public string CProcessType { get; set; }

    public long? CMvmTransportorderPk { get; set; }

    public bool CShippingFailure { get; set; }

    public bool CIsFixDeliveryDate { get; set; }

    public virtual ICollection<WmsShpOrderPosition> WmsShpOrderPositions { get; set; } = new List<WmsShpOrderPosition>();
}
