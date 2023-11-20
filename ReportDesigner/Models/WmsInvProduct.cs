using System;
using System.Collections.Generic;

namespace ReportDesigner.Models;

public partial class WmsInvProduct
{
    public long CPk { get; set; }

    public DateTime? CCreated { get; set; }

    public DateTime? CUpdated { get; set; }

    public long? COl { get; set; }

    public string CPid { get; set; }

    public string CAccount { get; set; }

    public string CAvState { get; set; }

    public string CBaseUnitType { get; set; }

    public string CBaseUnitQty { get; set; }

    public string CClassification { get; set; }

    public string CWeightType { get; set; }

    public decimal? CWeight { get; set; }

    public string CDescription { get; set; }

    public decimal? CHeight { get; set; }

    public decimal? CLength { get; set; }

    public string CUom { get; set; }

    public decimal? CWidth { get; set; }

    public string CGroup { get; set; }

    public string CLabel { get; set; }

    public string CSku { get; set; }

    public string CStockZone { get; set; }

    public long? CPreferableStorageLocation { get; set; }

    public string CDescriptionText { get; set; }

    public int CNumberPerTu { get; set; }

    public int CStackingFactor { get; set; }

    public int? CPiecesPerLayer { get; set; }

    public int? CNumberOfLayers { get; set; }

    public string CTransportUnitText { get; set; }

    public string CBasicTuType { get; set; }

    public decimal? CTransportUnitWeight { get; set; }

    public decimal? CTransportUnitWidth { get; set; }

    public decimal? CTransportUnitHeight { get; set; }

    public decimal? CTransportUnitLength { get; set; }

    public string CDescription2 { get; set; }

    public decimal? CWeightGross { get; set; }

    public string CPickingInfo { get; set; }

    public int CSingleMaxTransportUnits { get; set; }

    public string CLeEinzeln { get; set; }

    public bool CGf01 { get; set; }

    public virtual WmsInvLocation CPreferableStorageLocationNavigation { get; set; }

    public virtual ICollection<WmsInvArticleLocationMap> WmsInvArticleLocationMaps { get; set; } = new List<WmsInvArticleLocationMap>();

    public virtual ICollection<WmsInvDiscrepancy> WmsInvDiscrepancies { get; set; } = new List<WmsInvDiscrepancy>();

    public virtual ICollection<WmsInvLoadUnit> WmsInvLoadUnits { get; set; } = new List<WmsInvLoadUnit>();

    public virtual ICollection<WmsInvPackagingUnit> WmsInvPackagingUnits { get; set; } = new List<WmsInvPackagingUnit>();

    public virtual ICollection<WmsInvPickOrderPosition> WmsInvPickOrderPositions { get; set; } = new List<WmsInvPickOrderPosition>();

    public virtual ICollection<WmsInvProductDetail> WmsInvProductDetails { get; set; } = new List<WmsInvProductDetail>();

    public virtual ICollection<WmsInvProductStackingRule> WmsInvProductStackingRuleCAllowedProductNavigations { get; set; } = new List<WmsInvProductStackingRule>();

    public virtual ICollection<WmsInvProductStackingRule> WmsInvProductStackingRuleCBaseProductNavigations { get; set; } = new List<WmsInvProductStackingRule>();

    public virtual ICollection<WmsInvProductUnit> WmsInvProductUnits { get; set; } = new List<WmsInvProductUnit>();

    public virtual ICollection<WmsInvProductZone> WmsInvProductZones { get; set; } = new List<WmsInvProductZone>();
}
