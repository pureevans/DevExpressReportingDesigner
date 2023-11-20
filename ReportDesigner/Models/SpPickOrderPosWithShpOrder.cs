using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class SpPickOrderPosWithShpOrder
{
    public string ProdSku { get; set; }

    public string ProdDescription { get; set; }

    public int PopQtyPick { get; set; }

    public string ShpOrderId { get; set; }

    public string PopState { get; set; }

    public long PopPk { get; set; }

    public long ProdPk { get; set; }

    public long ShpPk { get; set; }

    public string PopOrderRef { get; set; }

    public long PopOrderPk { get; set; }

    public int QtyShippingOrder { get; set; }

    public int? PopPosId { get; set; }

    public long ShpPosPk { get; set; }

    public int PopQtyPicked { get; set; }

    public string CProblemMessage { get; set; }

    public string CSoureLocations { get; set; }
}
