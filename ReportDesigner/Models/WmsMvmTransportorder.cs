using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsMvmTransportorder
{
    public long CPk { get; set; }

    public DateTime CCreated { get; set; }

    public DateTime CStartDate { get; set; }

    public DateTime CLatestDue { get; set; }

    public DateTime CPickUpDate { get; set; }

    public DateTime CDeliveryDate { get; set; }

    public string CSourceLocationGroup { get; set; }

    public string CTargetLocation { get; set; }

    public string CTargetLocationGroup { get; set; }

    public string CCustomerNo { get; set; }

    public string COrderId { get; set; }

    public string COrderState { get; set; }

    public int CPriority { get; set; }

    public string CProblemMessage { get; set; }

    public string CShippingType { get; set; }

    public string CStartMode { get; set; }

    public string CCountry { get; set; }

    public string CCustomerGroup { get; set; }

    public string CCustomerName { get; set; }

    public string COrdertype { get; set; }

    public string CShipper { get; set; }

    public decimal? CWeight { get; set; }

    public string CMyfactoryOrderNumber { get; set; }

    public string COrderSource { get; set; }

    public string CTitle { get; set; }

    public string CErpOrderId { get; set; }

    public bool CSplitDelivery { get; set; }

    public virtual ICollection<WmsMvmTransportorderPosition> WmsMvmTransportorderPositions { get; set; } = new List<WmsMvmTransportorderPosition>();
}
