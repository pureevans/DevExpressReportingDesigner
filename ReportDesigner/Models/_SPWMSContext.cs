using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReportDesigner.Models;

public partial class _SPWMSContext : DbContext
{
    public _SPWMSContext()
    {
    }

    public _SPWMSContext(DbContextOptions<_SPWMSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ComAccount> ComAccounts { get; set; }

    public virtual DbSet<ComBarcode> ComBarcodes { get; set; }

    public virtual DbSet<ComLocation> ComLocations { get; set; }

    public virtual DbSet<ComLocationGroup> ComLocationGroups { get; set; }

    public virtual DbSet<ComLocationMessage> ComLocationMessages { get; set; }

    public virtual DbSet<ComLocationType> ComLocationTypes { get; set; }

    public virtual DbSet<ComSrvRevision> ComSrvRevisions { get; set; }

    public virtual DbSet<ComTransaction> ComTransactions { get; set; }

    public virtual DbSet<ComTransactionDetail> ComTransactionDetails { get; set; }

    public virtual DbSet<ComTransportUnit> ComTransportUnits { get; set; }

    public virtual DbSet<ComTransportUnitLog> ComTransportUnitLogs { get; set; }

    public virtual DbSet<ComTransportUnitType> ComTransportUnitTypes { get; set; }

    public virtual DbSet<ComTypePlacingRule> ComTypePlacingRules { get; set; }

    public virtual DbSet<ComTypeStackingRule> ComTypeStackingRules { get; set; }

    public virtual DbSet<ComUnitError> ComUnitErrors { get; set; }

    public virtual DbSet<CorMessage> CorMessages { get; set; }

    public virtual DbSet<CorPrefPreference> CorPrefPreferences { get; set; }

    public virtual DbSet<CorPrtPrintJob> CorPrtPrintJobs { get; set; }

    public virtual DbSet<CorPrtPrinter> CorPrtPrinters { get; set; }

    public virtual DbSet<CorPrtReport> CorPrtReports { get; set; }

    public virtual DbSet<CorPrtReportJob> CorPrtReportJobs { get; set; }

    public virtual DbSet<CorUaaClient> CorUaaClients { get; set; }

    public virtual DbSet<CorUaaClientDetail> CorUaaClientDetails { get; set; }

    public virtual DbSet<CorUaaEmail> CorUaaEmails { get; set; }

    public virtual DbSet<CorUaaRole> CorUaaRoles { get; set; }

    public virtual DbSet<CorUaaUser> CorUaaUsers { get; set; }

    public virtual DbSet<CorUaaUserPassword> CorUaaUserPasswords { get; set; }

    public virtual DbSet<DiabloConfig> DiabloConfigs { get; set; }

    public virtual DbSet<DiabloInventoryReport> DiabloInventoryReports { get; set; }

    public virtual DbSet<DiabloProductPictureTransfer> DiabloProductPictureTransfers { get; set; }

    public virtual DbSet<DiabloReplenishmentLocationgroup> DiabloReplenishmentLocationgroups { get; set; }

    public virtual DbSet<DiabloReplenishmentView> DiabloReplenishmentViews { get; set; }

    public virtual DbSet<DiabloReplenishmentViewAdminGui> DiabloReplenishmentViewAdminGuis { get; set; }

    public virtual DbSet<DiabloUser> DiabloUsers { get; set; }

    public virtual DbSet<DiabloUserGrant> DiabloUserGrants { get; set; }

    public virtual DbSet<DiabloUserGrantMapping> DiabloUserGrantMappings { get; set; }

    public virtual DbSet<DiabloUserLocationGroupMapping> DiabloUserLocationGroupMappings { get; set; }

    public virtual DbSet<MvmMovement> MvmMovements { get; set; }

    public virtual DbSet<MvmMovementGroup> MvmMovementGroups { get; set; }

    public virtual DbSet<MvmProblemHistory> MvmProblemHistories { get; set; }

    public virtual DbSet<SpEmptyAndFilledLocation> SpEmptyAndFilledLocations { get; set; }

    public virtual DbSet<SpEmptyLocation> SpEmptyLocations { get; set; }

    public virtual DbSet<SpEmptyTuLocation> SpEmptyTuLocations { get; set; }

    public virtual DbSet<SpInventoryCreation> SpInventoryCreations { get; set; }

    public virtual DbSet<SpInventoryOpenReconcilation> SpInventoryOpenReconcilations { get; set; }

    public virtual DbSet<SpInventoryReport> SpInventoryReports { get; set; }

    public virtual DbSet<SpLocation> SpLocations { get; set; }

    public virtual DbSet<SpPickOrderPosWithShpOrder> SpPickOrderPosWithShpOrders { get; set; }

    public virtual DbSet<SpStockEmptyPickLocationTu> SpStockEmptyPickLocationTus { get; set; }

    public virtual DbSet<SpStockList> SpStockLists { get; set; }

    public virtual DbSet<SpStockListNolock> SpStockListNolocks { get; set; }

    public virtual DbSet<TempReport> TempReports { get; set; }

    public virtual DbSet<Temptable> Temptables { get; set; }

    public virtual DbSet<WmsInvArticleLocationMap> WmsInvArticleLocationMaps { get; set; }

    public virtual DbSet<WmsInvDiscrepancy> WmsInvDiscrepancies { get; set; }

    public virtual DbSet<WmsInvFillLevel> WmsInvFillLevels { get; set; }

    public virtual DbSet<WmsInvFillup> WmsInvFillups { get; set; }

    public virtual DbSet<WmsInvLoadUnit> WmsInvLoadUnits { get; set; }

    public virtual DbSet<WmsInvLoadUnitLog> WmsInvLoadUnitLogs { get; set; }

    public virtual DbSet<WmsInvLoadUnitType> WmsInvLoadUnitTypes { get; set; }

    public virtual DbSet<WmsInvLocation> WmsInvLocations { get; set; }

    public virtual DbSet<WmsInvLocationLog> WmsInvLocationLogs { get; set; }

    public virtual DbSet<WmsInvLocationType> WmsInvLocationTypes { get; set; }

    public virtual DbSet<WmsInvOrderReference> WmsInvOrderReferences { get; set; }

    public virtual DbSet<WmsInvPackagingUnit> WmsInvPackagingUnits { get; set; }

    public virtual DbSet<WmsInvPackagingUnitLog> WmsInvPackagingUnitLogs { get; set; }

    public virtual DbSet<WmsInvPickDetail> WmsInvPickDetails { get; set; }

    public virtual DbSet<WmsInvPickDetailLog> WmsInvPickDetailLogs { get; set; }

    public virtual DbSet<WmsInvPickOrder> WmsInvPickOrders { get; set; }

    public virtual DbSet<WmsInvPickOrderId> WmsInvPickOrderIds { get; set; }

    public virtual DbSet<WmsInvPickOrderLog> WmsInvPickOrderLogs { get; set; }

    public virtual DbSet<WmsInvPickOrderPosReference> WmsInvPickOrderPosReferences { get; set; }

    public virtual DbSet<WmsInvPickOrderPosSplit> WmsInvPickOrderPosSplits { get; set; }

    public virtual DbSet<WmsInvPickOrderPosSplitLog> WmsInvPickOrderPosSplitLogs { get; set; }

    public virtual DbSet<WmsInvPickOrderPosition> WmsInvPickOrderPositions { get; set; }

    public virtual DbSet<WmsInvPickOrderPositionLog> WmsInvPickOrderPositionLogs { get; set; }

    public virtual DbSet<WmsInvPickOrderTu> WmsInvPickOrderTus { get; set; }

    public virtual DbSet<WmsInvPickOrderTuLog> WmsInvPickOrderTuLogs { get; set; }

    public virtual DbSet<WmsInvPickOrderTuReference> WmsInvPickOrderTuReferences { get; set; }

    public virtual DbSet<WmsInvProduct> WmsInvProducts { get; set; }

    public virtual DbSet<WmsInvProductDetail> WmsInvProductDetails { get; set; }

    public virtual DbSet<WmsInvProductLog> WmsInvProductLogs { get; set; }

    public virtual DbSet<WmsInvProductStackingRule> WmsInvProductStackingRules { get; set; }

    public virtual DbSet<WmsInvProductUnit> WmsInvProductUnits { get; set; }

    public virtual DbSet<WmsInvProductUnitDetail> WmsInvProductUnitDetails { get; set; }

    public virtual DbSet<WmsInvProductZone> WmsInvProductZones { get; set; }

    public virtual DbSet<WmsInvReservation> WmsInvReservations { get; set; }

    public virtual DbSet<WmsInvReservationLog> WmsInvReservationLogs { get; set; }

    public virtual DbSet<WmsInvRevision> WmsInvRevisions { get; set; }

    public virtual DbSet<WmsInvTask> WmsInvTasks { get; set; }

    public virtual DbSet<WmsInvTransaction> WmsInvTransactions { get; set; }

    public virtual DbSet<WmsInvTransportUnit> WmsInvTransportUnits { get; set; }

    public virtual DbSet<WmsMvmTransportorder> WmsMvmTransportorders { get; set; }

    public virtual DbSet<WmsMvmTransportorderPosition> WmsMvmTransportorderPositions { get; set; }

    public virtual DbSet<WmsRecOrder> WmsRecOrders { get; set; }

    public virtual DbSet<WmsRecOrderDetail> WmsRecOrderDetails { get; set; }

    public virtual DbSet<WmsRecOrderId> WmsRecOrderIds { get; set; }

    public virtual DbSet<WmsRecOrderPosition> WmsRecOrderPositions { get; set; }

    public virtual DbSet<WmsRecOrderPositionDetail> WmsRecOrderPositionDetails { get; set; }

    public virtual DbSet<WmsRecOrderPostionErp> WmsRecOrderPostionErps { get; set; }

    public virtual DbSet<WmsRecProduct> WmsRecProducts { get; set; }

    public virtual DbSet<WmsRecTransportUnit> WmsRecTransportUnits { get; set; }

    public virtual DbSet<WmsReplenishmentReason> WmsReplenishmentReasons { get; set; }

    public virtual DbSet<WmsReport> WmsReports { get; set; }

    public virtual DbSet<WmsShipmentType> WmsShipmentTypes { get; set; }

    public virtual DbSet<WmsShipper> WmsShippers { get; set; }

    public virtual DbSet<WmsShpOrder> WmsShpOrders { get; set; }

    public virtual DbSet<WmsShpOrderDetail> WmsShpOrderDetails { get; set; }

    public virtual DbSet<WmsShpOrderId> WmsShpOrderIds { get; set; }

    public virtual DbSet<WmsShpOrderPosition> WmsShpOrderPositions { get; set; }

    public virtual DbSet<WmsShpOrderPositionDetail> WmsShpOrderPositionDetails { get; set; }

    public virtual DbSet<WmsShpOrderPositionSplit> WmsShpOrderPositionSplits { get; set; }

    public virtual DbSet<WmsShpProduct> WmsShpProducts { get; set; }

    public virtual DbSet<WmsShpProductDetail> WmsShpProductDetails { get; set; }

    public virtual DbSet<WmsTaskGroup> WmsTaskGroups { get; set; }

    public virtual DbSet<WmsTaskReconciliation> WmsTaskReconciliations { get; set; }

    public virtual DbSet<WmsTaskReconciliationReport> WmsTaskReconciliationReports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data source = svhesqld; Initial Catalog=SPWMSDEV; User Id=spwmsdev;Password=sa_superuser;Persist Security Info=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ComAccount>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_account_pkey");

            entity.ToTable("com_account");

            entity.HasIndex(e => e.CIdentifier, "uc_acc_id").IsUnique();

            entity.HasIndex(e => e.CName, "uc_acc_name").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDefault).HasColumnName("c_default");
            entity.Property(e => e.CIdentifier)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_identifier");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<ComBarcode>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_barcode_pkey");

            entity.ToTable("com_barcode");

            entity.HasIndex(e => e.CName, "ukn8mc3vy68ogenxtjqgpw23shx").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCurrent)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("c_current");
            entity.Property(e => e.CName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<ComLocation>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_location_pkey");

            entity.ToTable("com_location");

            entity.HasIndex(e => new { e.CArea, e.CAisle, e.CX, e.CY, e.CZ }, "uc_loc_id").IsUnique();

            entity.HasIndex(e => e.CPlcCode, "uk_6j2cwfpxn549vlfupsaxh95i4").IsUnique();

            entity.HasIndex(e => e.CErpCode, "uk_84fpvvehdtcv8g56lhd5lng38").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_account");
            entity.Property(e => e.CAisle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_aisle");
            entity.Property(e => e.CArea)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CCheckState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_check_state");
            entity.Property(e => e.CClassification)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_classification");
            entity.Property(e => e.CConsideredInAllocation).HasColumnName("c_considered_in_allocation");
            entity.Property(e => e.CCountingActive).HasColumnName("c_counting_active");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDirectBookingAllowed).HasColumnName("c_direct_booking_allowed");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CLabels)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_labels");
            entity.Property(e => e.CLastMovement)
                .HasColumnType("datetime")
                .HasColumnName("c_last_movement");
            entity.Property(e => e.CLgCountingActive).HasColumnName("c_lg_counting_active");
            entity.Property(e => e.CLocationGroup).HasColumnName("c_location_group");
            entity.Property(e => e.CLocationType).HasColumnName("c_location_type");
            entity.Property(e => e.CMaximumWeight)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("c_maximum_weight");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPlcCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_plc_code");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CStockZone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_stock_zone");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CX)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_x");
            entity.Property(e => e.CY)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_y");
            entity.Property(e => e.CZ)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_z");

            entity.HasOne(d => d.CAccountNavigation).WithMany(p => p.ComLocations)
                .HasPrincipalKey(p => p.CIdentifier)
                .HasForeignKey(d => d.CAccount)
                .HasConstraintName("fk_loc_acc");

            entity.HasOne(d => d.CLocationGroupNavigation).WithMany(p => p.ComLocations)
                .HasForeignKey(d => d.CLocationGroup)
                .HasConstraintName("fk_loc_lg");

            entity.HasOne(d => d.CLocationTypeNavigation).WithMany(p => p.ComLocations)
                .HasForeignKey(d => d.CLocationType)
                .HasConstraintName("fk_loc_lt");
        });

        modelBuilder.Entity<ComLocationGroup>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_location_group_pkey");

            entity.ToTable("com_location_group");

            entity.HasIndex(e => e.CName, "uk_1qq4taa8n4nidelembye5u4in").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_account");
            entity.Property(e => e.CCity)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_city");
            entity.Property(e => e.CCountry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_country");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CEmail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_email");
            entity.Property(e => e.CGroupCountingActive).HasColumnName("c_group_counting_active");
            entity.Property(e => e.CGroupStateIn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group_state_in");
            entity.Property(e => e.CGroupStateOut)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group_state_out");
            entity.Property(e => e.CGroupType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group_type");
            entity.Property(e => e.CInLocker).HasColumnName("c_in_locker");
            entity.Property(e => e.CIsExternal).HasColumnName("c_is_external");
            entity.Property(e => e.CMaxFillLevel).HasColumnName("c_max_fill_level");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.CName1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name_1");
            entity.Property(e => e.CName2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name_2");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COpMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_op_mode");
            entity.Property(e => e.COutLocker).HasColumnName("c_out_locker");
            entity.Property(e => e.CParent).HasColumnName("c_parent");
            entity.Property(e => e.CPhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_phone_number");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPostalCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_postal_code");
            entity.Property(e => e.CReorg).HasColumnName("c_reorg");
            entity.Property(e => e.CStreet1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_street_1");
            entity.Property(e => e.CStreet2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_street_2");
            entity.Property(e => e.CSystemCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_system_code");
            entity.Property(e => e.CSystemName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_system_name");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CAccountNavigation).WithMany(p => p.ComLocationGroups)
                .HasPrincipalKey(p => p.CIdentifier)
                .HasForeignKey(d => d.CAccount)
                .HasConstraintName("fk_lg_acc");

            entity.HasOne(d => d.CInLockerNavigation).WithMany(p => p.InverseCInLockerNavigation)
                .HasForeignKey(d => d.CInLocker)
                .HasConstraintName("fk_lg_lg_inlocker");

            entity.HasOne(d => d.COutLockerNavigation).WithMany(p => p.InverseCOutLockerNavigation)
                .HasForeignKey(d => d.COutLocker)
                .HasConstraintName("fk_lg_lg_outlocker");

            entity.HasOne(d => d.CParentNavigation).WithMany(p => p.InverseCParentNavigation)
                .HasForeignKey(d => d.CParent)
                .HasConstraintName("fk_lg_lg_parent");
        });

        modelBuilder.Entity<ComLocationMessage>(entity =>
        {
            entity.HasKey(e => new { e.CLocationId, e.CMessageId }).HasName("com_location_message_pkey");

            entity.ToTable("com_location_message");

            entity.HasIndex(e => e.CMessageId, "uk_4k2m61gpiqdjsiped3m8mb3ao").IsUnique();

            entity.Property(e => e.CLocationId).HasColumnName("c_location_id");
            entity.Property(e => e.CMessageId).HasColumnName("c_message_id");

            entity.HasOne(d => d.CLocation).WithMany(p => p.ComLocationMessages)
                .HasForeignKey(d => d.CLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkcy1pukrprpi3lh48xhf44lk2a");

            entity.HasOne(d => d.CMessage).WithOne(p => p.ComLocationMessage)
                .HasForeignKey<ComLocationMessage>(d => d.CMessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkpa9ruvoy3id2cjat3hjkt6i7d");
        });

        modelBuilder.Entity<ComLocationType>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_location_type_pkey");

            entity.ToTable("com_location_type");

            entity.HasIndex(e => e.CType, "uk_h6r9kr990ufge67kp6g1p8kcw").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWidth).HasColumnName("c_width");
        });

        modelBuilder.Entity<ComSrvRevision>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_srv_revision_pkey");

            entity.ToTable("com_srv_revision");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CTimestamp).HasColumnName("c_timestamp");
            entity.Property(e => e.CTraceId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_trace_id");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");
        });

        modelBuilder.Entity<ComTransaction>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_transaction_pkey");

            entity.ToTable("com_transaction");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCategory)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_category");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCreatedByUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_created_by_user");
            entity.Property(e => e.CDescription)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CSender)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sender");
            entity.Property(e => e.CSenderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sender_id");
            entity.Property(e => e.CTraceId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_trace_id");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<ComTransactionDetail>(entity =>
        {
            entity.HasKey(e => new { e.CTxPk, e.CKey }).HasName("com_transaction_detail_pkey");

            entity.ToTable("com_transaction_detail");

            entity.Property(e => e.CTxPk).HasColumnName("c_tx_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");
        });

        modelBuilder.Entity<ComTransportUnit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_transport_unit_pkey");

            entity.ToTable("com_transport_unit");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CActualLocation).HasColumnName("c_actual_location");
            entity.Property(e => e.CActualLocationDate)
                .HasColumnType("datetime")
                .HasColumnName("c_actual_location_date");
            entity.Property(e => e.CBarcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_barcode");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CEmpty).HasColumnName("c_empty");
            entity.Property(e => e.CGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group_id");
            entity.Property(e => e.CInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_inventory_date");
            entity.Property(e => e.CInventoryUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_inventory_user");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CParent).HasColumnName("c_parent");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTargetLocation).HasColumnName("c_target_location");
            entity.Property(e => e.CTransportUnitType).HasColumnName("c_transport_unit_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("c_weight");
            entity.Property(e => e.CWeightUom).HasColumnName("c_weight_uom");

            entity.HasOne(d => d.CActualLocationNavigation).WithMany(p => p.ComTransportUnitCActualLocationNavigations)
                .HasForeignKey(d => d.CActualLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("com_tu_fk_loc_actual");

            entity.HasOne(d => d.CParentNavigation).WithMany(p => p.InverseCParentNavigation)
                .HasForeignKey(d => d.CParent)
                .HasConstraintName("com_tu_fk_tu_parent");

            entity.HasOne(d => d.CTargetLocationNavigation).WithMany(p => p.ComTransportUnitCTargetLocationNavigations)
                .HasForeignKey(d => d.CTargetLocation)
                .HasConstraintName("com_tu_fk_loc_target");

            entity.HasOne(d => d.CTransportUnitTypeNavigation).WithMany(p => p.ComTransportUnits)
                .HasForeignKey(d => d.CTransportUnitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("com_tu_fk_tut");
        });

        modelBuilder.Entity<ComTransportUnitLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("com_transport_unit_log_pkey");

            entity.ToTable("com_transport_unit_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CActualLocation).HasColumnName("c_actual_location");
            entity.Property(e => e.CActualLocationDate)
                .HasColumnType("datetime")
                .HasColumnName("c_actual_location_date");
            entity.Property(e => e.CBarcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_barcode");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CEmpty).HasColumnName("c_empty");
            entity.Property(e => e.CGroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group_id");
            entity.Property(e => e.CInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_inventory_date");
            entity.Property(e => e.CInventoryUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_inventory_user");
            entity.Property(e => e.CParent).HasColumnName("c_parent");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTargetLocation).HasColumnName("c_target_location");
            entity.Property(e => e.CTransportUnitType).HasColumnName("c_transport_unit_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("c_weight");
            entity.Property(e => e.CWeightUom).HasColumnName("c_weight_uom");
        });

        modelBuilder.Entity<ComTransportUnitType>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_transport_unit_type_pkey");

            entity.ToTable("com_transport_unit_type");

            entity.HasIndex(e => e.CType, "uc_tut_type").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAddWeight).HasColumnName("c_add_weight");
            entity.Property(e => e.CCompatibility)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_compatibility");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPayload)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("c_payload");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CSequence).HasColumnName("c_sequence");
            entity.Property(e => e.CShipment).HasColumnName("c_shipment");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeightMax)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("c_weight_max");
            entity.Property(e => e.CWeightTare)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("c_weight_tare");
            entity.Property(e => e.CWidth).HasColumnName("c_width");
        });

        modelBuilder.Entity<ComTypePlacingRule>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_type_placing_rule_pkey");

            entity.ToTable("com_type_placing_rule");

            entity.HasIndex(e => new { e.CTutId, e.CPrivilegeLevel, e.CAllowedLocationType }, "uk356v9mmollkl6m8ht47fb9lmw").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAllowedLocationType).HasColumnName("c_allowed_location_type");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPrivilegeLevel).HasColumnName("c_privilege_level");
            entity.Property(e => e.CTutId).HasColumnName("c_tut_id");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CAllowedLocationTypeNavigation).WithMany(p => p.ComTypePlacingRules)
                .HasForeignKey(d => d.CAllowedLocationType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkb1he5781gaupx0napfkoy09iy");

            entity.HasOne(d => d.CTut).WithMany(p => p.ComTypePlacingRules)
                .HasForeignKey(d => d.CTutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkexme0g9srxcxt8m3jv2101k1d");
        });

        modelBuilder.Entity<ComTypeStackingRule>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_type_stacking_rule_pkey");

            entity.ToTable("com_type_stacking_rule");

            entity.HasIndex(e => new { e.CTransportUnitType, e.CNoTransportUnits, e.CAllowedTransportUnitType }, "uk2chb3j2y6bn68n3rfnp0gpvcm").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAllowedTransportUnitType).HasColumnName("c_allowed_transport_unit_type");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CNoTransportUnits).HasColumnName("c_no_transport_units");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CTransportUnitType).HasColumnName("c_transport_unit_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CAllowedTransportUnitTypeNavigation).WithMany(p => p.ComTypeStackingRuleCAllowedTransportUnitTypeNavigations)
                .HasForeignKey(d => d.CAllowedTransportUnitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk9wojgpvaignw39k200ha80eug");

            entity.HasOne(d => d.CTransportUnitTypeNavigation).WithMany(p => p.ComTypeStackingRuleCTransportUnitTypeNavigations)
                .HasForeignKey(d => d.CTransportUnitType)
                .HasConstraintName("fk6pn2579hr73ige890tnrtlids");
        });

        modelBuilder.Entity<ComUnitError>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("com_unit_error_pkey");

            entity.ToTable("com_unit_error");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CErrorNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_error_no");
            entity.Property(e => e.CErrorText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_error_text");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CTuId).HasColumnName("c_tu_id");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CTu).WithMany(p => p.ComUnitErrors)
                .HasForeignKey(d => d.CTuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tu_error_pk");
        });

        modelBuilder.Entity<CorMessage>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_message_pkey");

            entity.ToTable("cor_message");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CMessageNo).HasColumnName("c_message_no");
            entity.Property(e => e.CMessageText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_message_text");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<CorPrefPreference>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_pref_preference_pkey");

            entity.ToTable("cor_pref_preference");

            entity.HasIndex(e => new { e.CKey, e.COwner }, "uc_preference").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCurrentValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_current_value");
            entity.Property(e => e.CDefValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_def_value");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CFromFile).HasColumnName("c_from_file");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CMaxValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_max_value");
            entity.Property(e => e.CMinValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_min_value");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COwner)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_owner");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CScope)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_scope");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<CorPrtPrintJob>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_prt_print_job_pkey");

            entity.ToTable("cor_prt_print_job");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCopies).HasColumnName("c_copies");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDevice)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_device");
            entity.Property(e => e.CMediaSize)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_media_size");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CReportRef)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_report_ref");
            entity.Property(e => e.CState).HasColumnName("c_state");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<CorPrtPrinter>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_prt_printer_pkey");

            entity.ToTable("cor_prt_printer");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.Barcode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("barcode");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.ClientGroup)
                .HasColumnType("numeric(19, 2)")
                .HasColumnName("client_group");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("client_name");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IpAddr)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ip_addr");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PortNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("port_no");
            entity.Property(e => e.PrinterId).HasColumnName("printer_id");
            entity.Property(e => e.RemotePassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remote_password");
            entity.Property(e => e.RemoteUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remote_user");
            entity.Property(e => e.Subtype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subtype");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CorPrtReport>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_prt_report_pkey");

            entity.ToTable("cor_prt_report");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CContent)
                .HasColumnType("text")
                .HasColumnName("c_content");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CMediaType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_media_type");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CTenant)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_tenant");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<CorPrtReportJob>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_prt_report_job_pkey");

            entity.ToTable("cor_prt_report_job");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CData)
                .HasColumnType("text")
                .HasColumnName("c_data");
            entity.Property(e => e.CMediaType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_media_type");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COutputFormat)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_output_format");
            entity.Property(e => e.CParameter)
                .HasColumnType("text")
                .HasColumnName("c_parameter");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CReportContentRef)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_report_content_ref");
            entity.Property(e => e.CState).HasColumnName("c_state");
            entity.Property(e => e.CTemplateName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_template_name");
            entity.Property(e => e.CTenant)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_tenant");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<CorUaaClient>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_uaa_client_pkey");

            entity.ToTable("cor_uaa_client");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAccessTokenValidity).HasColumnName("c_access_token_validity");
            entity.Property(e => e.CAdditionalInformation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_additional_information");
            entity.Property(e => e.CAuthorities)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_authorities");
            entity.Property(e => e.CAuthorizedGrantTypes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_authorized_grant_types");
            entity.Property(e => e.CAutoapprove)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_autoapprove");
            entity.Property(e => e.CClientId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_client_id");
            entity.Property(e => e.CClientSecret)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_client_secret");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CRefreshTokenValidity).HasColumnName("c_refresh_token_validity");
            entity.Property(e => e.CResourceIds)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_resource_ids");
            entity.Property(e => e.CScope)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_scope");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWebServerRedirectUri)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_web_server_redirect_uri");
        });

        modelBuilder.Entity<CorUaaClientDetail>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_uaa_client_details_pkey");

            entity.ToTable("cor_uaa_client_details");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAccessTokenValidity).HasColumnName("c_access_token_validity");
            entity.Property(e => e.CAdditionalInformation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_additional_information");
            entity.Property(e => e.CAuthorities)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_authorities");
            entity.Property(e => e.CAuthorizedGrantTypes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_authorized_grant_types");
            entity.Property(e => e.CAutoapprove)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_autoapprove");
            entity.Property(e => e.CClientId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_client_id");
            entity.Property(e => e.CClientSecret)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_client_secret");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CRefreshTokenValidity).HasColumnName("c_refresh_token_validity");
            entity.Property(e => e.CResourceIds)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_resource_ids");
            entity.Property(e => e.CScope)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_scope");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWebServerRedirectUri)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_web_server_redirect_uri");
        });

        modelBuilder.Entity<CorUaaEmail>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_uaa_email_pkey");

            entity.ToTable("cor_uaa_email");

            entity.HasIndex(e => new { e.CUsername, e.CAddress }, "uc_email_user").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAddress)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_address");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CFullName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_full_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPrimary).HasColumnName("c_primary");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUsername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_username");

            entity.HasOne(d => d.CUsernameNavigation).WithMany(p => p.CorUaaEmails)
                .HasPrincipalKey(p => p.CUsername)
                .HasForeignKey(d => d.CUsername)
                .HasConstraintName("fk_uaa_user_email");
        });

        modelBuilder.Entity<CorUaaRole>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_uaa_role_pkey");

            entity.ToTable("cor_uaa_role");

            entity.HasIndex(e => e.CName, "uc_uaa_role").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CImmutable).HasColumnName("c_immutable");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasMany(d => d.CGrants).WithMany(p => p.CRoles)
                .UsingEntity<Dictionary<string, object>>(
                    "CorUaaRoleRole",
                    r => r.HasOne<CorUaaRole>().WithMany()
                        .HasForeignKey("CGrantId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_uaa_grant_role"),
                    l => l.HasOne<CorUaaRole>().WithMany()
                        .HasForeignKey("CRoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_uaa_role_grant"),
                    j =>
                    {
                        j.HasKey("CRoleId", "CGrantId").HasName("cor_uaa_role_role_pkey");
                        j.ToTable("cor_uaa_role_role");
                        j.IndexerProperty<long>("CRoleId").HasColumnName("c_role_id");
                        j.IndexerProperty<long>("CGrantId").HasColumnName("c_grant_id");
                    });

            entity.HasMany(d => d.CRoles).WithMany(p => p.CGrants)
                .UsingEntity<Dictionary<string, object>>(
                    "CorUaaRoleRole",
                    r => r.HasOne<CorUaaRole>().WithMany()
                        .HasForeignKey("CRoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_uaa_role_grant"),
                    l => l.HasOne<CorUaaRole>().WithMany()
                        .HasForeignKey("CGrantId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_uaa_grant_role"),
                    j =>
                    {
                        j.HasKey("CRoleId", "CGrantId").HasName("cor_uaa_role_role_pkey");
                        j.ToTable("cor_uaa_role_role");
                        j.IndexerProperty<long>("CRoleId").HasColumnName("c_role_id");
                        j.IndexerProperty<long>("CGrantId").HasColumnName("c_grant_id");
                    });

            entity.HasMany(d => d.CUsers).WithMany(p => p.CRoles)
                .UsingEntity<Dictionary<string, object>>(
                    "CorUaaRoleUser",
                    r => r.HasOne<CorUaaUser>().WithMany()
                        .HasForeignKey("CUserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_uaa_user_role"),
                    l => l.HasOne<CorUaaRole>().WithMany()
                        .HasForeignKey("CRoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("fk_uaa_role_user"),
                    j =>
                    {
                        j.HasKey("CRoleId", "CUserId").HasName("cor_uaa_role_user_pkey");
                        j.ToTable("cor_uaa_role_user");
                        j.IndexerProperty<long>("CRoleId").HasColumnName("c_role_id");
                        j.IndexerProperty<long>("CUserId").HasColumnName("c_user_id");
                    });
        });

        modelBuilder.Entity<CorUaaUser>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_uaa_user_pkey");

            entity.ToTable("cor_uaa_user");

            entity.HasIndex(e => e.CUsername, "uc_uaa_user_name").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CComment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_comment");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDepartment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_department");
            entity.Property(e => e.CDescription)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CEnabled).HasColumnName("c_enabled");
            entity.Property(e => e.CExpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("c_expiration_date");
            entity.Property(e => e.CExtern).HasColumnName("c_extern");
            entity.Property(e => e.CFullname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_fullname");
            entity.Property(e => e.CGender)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_gender");
            entity.Property(e => e.CIm)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_im");
            entity.Property(e => e.CImage).HasColumnName("c_image");
            entity.Property(e => e.CLastPasswordChange)
                .HasColumnType("datetime")
                .HasColumnName("c_last_password_change");
            entity.Property(e => e.CLocked).HasColumnName("c_locked");
            entity.Property(e => e.COffice)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_office");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_password");
            entity.Property(e => e.CPhoneNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_phone_no");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CSalt)
                .HasMaxLength(255)
                .HasColumnName("c_salt");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUsername)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_username");
        });

        modelBuilder.Entity<CorUaaUserPassword>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("cor_uaa_user_password_pkey");

            entity.ToTable("cor_uaa_user_password");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_password");
            entity.Property(e => e.CPasswordChanged)
                .HasColumnType("datetime")
                .HasColumnName("c_password_changed");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUsername)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_username");

            entity.HasOne(d => d.CUsernameNavigation).WithMany(p => p.CorUaaUserPasswords)
                .HasPrincipalKey(p => p.CUsername)
                .HasForeignKey(d => d.CUsername)
                .HasConstraintName("fk_uaa_pw_user");
        });

        modelBuilder.Entity<DiabloConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("diablo_config");

            entity.Property(e => e.CConfigname)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("c_configname");
            entity.Property(e => e.CId)
                .ValueGeneratedOnAdd()
                .HasColumnName("c_id");
            entity.Property(e => e.CLocationgroup)
                .HasMaxLength(50)
                .HasColumnName("c_locationgroup");
            entity.Property(e => e.CValue)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("c_value");
        });

        modelBuilder.Entity<DiabloInventoryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("diablo_inventory_report");

            entity.Property(e => e.CCountType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_count_type");
            entity.Property(e => e.CCountedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_counted_at");
            entity.Property(e => e.CCountedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_counted_by");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CFinishedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_finished_at");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CQtyCounted).HasColumnName("c_qty_counted");
            entity.Property(e => e.CQtyExpected).HasColumnName("c_qty_expected");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_started_at");
            entity.Property(e => e.Countedtu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("countedtu");
            entity.Property(e => e.Inventorystate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("inventorystate");
            entity.Property(e => e.Locationgroup)
                .HasMaxLength(50)
                .HasColumnName("locationgroup");
            entity.Property(e => e.Parentlocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("parentlocation");
        });

        modelBuilder.Entity<DiabloProductPictureTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("diablo_product_picture_transfer");

            entity.Property(e => e.CPicture).HasColumnName("c_picture");
            entity.Property(e => e.CPk)
                .ValueGeneratedOnAdd()
                .HasColumnName("c_pk");
            entity.Property(e => e.CSku)
                .HasMaxLength(50)
                .HasColumnName("c_sku");
        });

        modelBuilder.Entity<DiabloReplenishmentLocationgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("diablo_replenishment_locationgroups");

            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.MinStock)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.TargetLocationGroup).HasMaxLength(200);
        });

        modelBuilder.Entity<DiabloReplenishmentView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("diablo_replenishment_view");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.MinStock)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SourceLocation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SoureLocationgroup)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TargetLocation).HasMaxLength(50);
            entity.Property(e => e.TargetLocationGroup).HasMaxLength(50);
        });

        modelBuilder.Entity<DiabloReplenishmentViewAdminGui>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("diablo_replenishment_view_admin_gui");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.MinStock)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.RecPickQty).HasColumnName("rec_pick_qty");
            entity.Property(e => e.SourceLocation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SoureLocationgroup)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TargetLocation).HasMaxLength(50);
            entity.Property(e => e.TargetLocationGroup).HasMaxLength(50);
        });

        modelBuilder.Entity<DiabloUser>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("diablo_user");

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.CCaddy)
                .HasMaxLength(100)
                .HasColumnName("c_caddy");
            entity.Property(e => e.CCanReopenShippingOrder).HasColumnName("c_can_reopen_shipping_order");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDepartment)
                .HasMaxLength(200)
                .HasColumnName("c_department");
            entity.Property(e => e.CEnabled).HasColumnName("c_enabled");
            entity.Property(e => e.CExtern).HasColumnName("c_extern");
            entity.Property(e => e.CFullname)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("c_fullname");
            entity.Property(e => e.CLastPasswortChange)
                .HasColumnType("datetime")
                .HasColumnName("c_last_passwort_change");
            entity.Property(e => e.CPassword)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("c_password");
            entity.Property(e => e.CPrinterLabel)
                .HasMaxLength(100)
                .HasColumnName("c_printer_label");
            entity.Property(e => e.CPrinterList)
                .HasMaxLength(100)
                .HasColumnName("c_printer_list");
            entity.Property(e => e.CResetPrinter).HasColumnName("c_reset_printer");
            entity.Property(e => e.CSalt)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("c_salt");
            entity.Property(e => e.CSelectedShipper)
                .HasMaxLength(100)
                .HasColumnName("c_selected_shipper");
            entity.Property(e => e.CSelectedWarehouse)
                .HasMaxLength(100)
                .HasColumnName("c_selected_warehouse");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUsername)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("c_username");
        });

        modelBuilder.Entity<DiabloUserGrant>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("diablo_user_grant");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("c_id");
            entity.Property(e => e.CApplication)
                .HasMaxLength(255)
                .HasColumnName("c_application");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("c_description");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("c_name");
        });

        modelBuilder.Entity<DiabloUserGrantMapping>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("diablo_user_grant_mapping");

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.CGrantId).HasColumnName("c_grant_id");
            entity.Property(e => e.CUserId).HasColumnName("c_user_id");

            entity.HasOne(d => d.CGrant).WithMany(p => p.DiabloUserGrantMappings)
                .HasForeignKey(d => d.CGrantId)
                .HasConstraintName("FK_diablo_user_grant_mapping_diablo_user_grant");

            entity.HasOne(d => d.CUser).WithMany(p => p.DiabloUserGrantMappings)
                .HasForeignKey(d => d.CUserId)
                .HasConstraintName("FK_diablo_user_grant_mapping_diablo_user");
        });

        modelBuilder.Entity<DiabloUserLocationGroupMapping>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("diablo_user_location_group_mapping");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("c_id");
            entity.Property(e => e.CLocationGroupId).HasColumnName("c_location_group_id");
            entity.Property(e => e.CUserId).HasColumnName("c_user_id");
        });

        modelBuilder.Entity<MvmMovement>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("mvm_movement_pkey");

            entity.ToTable("mvm_movement");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CEndDate)
                .HasColumnType("datetime")
                .HasColumnName("c_end_date");
            entity.Property(e => e.CGroupPk).HasColumnName("c_group_pk");
            entity.Property(e => e.CInitiator)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_initiator");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CMessage)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_message");
            entity.Property(e => e.CMode)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_mode");
            entity.Property(e => e.CMvmTransportorderPosId).HasColumnName("c_mvm_transportorderPos_id");
            entity.Property(e => e.CNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_no");
            entity.Property(e => e.COccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_occurred");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPickorderPosId).HasColumnName("c_pickorder_pos_id");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPriority)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_priority");
            entity.Property(e => e.CQty).HasColumnName("c_qty");
            entity.Property(e => e.CReceivingOrderPositionId).HasColumnName("c_receiving_order_position_id");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CSourceLocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_source_location");
            entity.Property(e => e.CSourceLocationGroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_source_location_group_name");
            entity.Property(e => e.CStartDate)
                .HasColumnType("datetime")
                .HasColumnName("c_start_date");
            entity.Property(e => e.CStartEarliestDate)
                .HasColumnType("datetime")
                .HasColumnName("c_start_earliest_date");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTargetLocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_location");
            entity.Property(e => e.CTargetLocationGroupName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_location_group_name");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CGroupPkNavigation).WithMany(p => p.MvmMovements)
                .HasForeignKey(d => d.CGroupPk)
                .HasConstraintName("fk_mvm_grp");
        });

        modelBuilder.Entity<MvmMovementGroup>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("mvm_movement_group_pkey");

            entity.ToTable("mvm_movement_group");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");
        });

        modelBuilder.Entity<MvmProblemHistory>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("mvm_problem_history_pkey");

            entity.ToTable("mvm_problem_history");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CFkMovement).HasColumnName("c_fk_movement");
            entity.Property(e => e.CMessage)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_message");
            entity.Property(e => e.CNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_no");
            entity.Property(e => e.COccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_occurred");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CFkMovementNavigation).WithMany(p => p.MvmProblemHistories)
                .HasForeignKey(d => d.CFkMovement)
                .HasConstraintName("fk_phistory_mvm");
        });

        modelBuilder.Entity<SpEmptyAndFilledLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_emptyAndFilled_location");

            entity.Property(e => e.CAisle)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_aisle");
            entity.Property(e => e.CArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDirectBookingAllowed).HasColumnName("c_direct_booking_allowed");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CForeignPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CIsReceivingLocation).HasColumnName("c_is_receiving_location");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CLastPickDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_pick_date");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CLocationType).HasColumnName("c_location_type");
            entity.Property(e => e.CMainLocationGroup)
                .HasMaxLength(50)
                .HasColumnName("c_main_location_group");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CMovementTarget).HasColumnName("c_movement_target");
            entity.Property(e => e.CNoInboundMovement).HasColumnName("c_no_inbound_movement");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CSplsDispo).HasColumnName("c_spls_dispo");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CX)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_x");
            entity.Property(e => e.CY)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_y");
            entity.Property(e => e.CZ)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_z");
            entity.Property(e => e.Stock)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpEmptyLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_empty_location");

            entity.Property(e => e.CAisle)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_aisle");
            entity.Property(e => e.CArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDirectBookingAllowed).HasColumnName("c_direct_booking_allowed");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CForeignPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CIsReceivingLocation).HasColumnName("c_is_receiving_location");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CLastPickDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_pick_date");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CLocationType).HasColumnName("c_location_type");
            entity.Property(e => e.CMainLocationGroup)
                .HasMaxLength(50)
                .HasColumnName("c_main_location_group");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CMovementTarget).HasColumnName("c_movement_target");
            entity.Property(e => e.CNoInboundMovement).HasColumnName("c_no_inbound_movement");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CSplsDispo).HasColumnName("c_spls_dispo");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CX)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_x");
            entity.Property(e => e.CY)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_y");
            entity.Property(e => e.CZ)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_z");
            entity.Property(e => e.Stock)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpEmptyTuLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_empty_tu_locations");

            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CMovementTarget).HasColumnName("c_movement_target");
            entity.Property(e => e.CNoInboundMovement).HasColumnName("c_no_inbound_movement");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.Isdispo).HasColumnName("isdispo");
            entity.Property(e => e.Locationdesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationdesc");
            entity.Property(e => e.Locationgrouploc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationgrouploc");
            entity.Property(e => e.MainLocationGroup)
                .HasMaxLength(50)
                .HasColumnName("mainLocationGroup");
        });

        modelBuilder.Entity<SpInventoryCreation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_inventory_creation");

            entity.Property(e => e.CAisle)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_aisle");
            entity.Property(e => e.CArea)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CX)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_x");
            entity.Property(e => e.CY)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_y");
            entity.Property(e => e.CZ)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_z");
            entity.Property(e => e.Locationgroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("locationgroup");
            entity.Property(e => e.Parentlocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("parentlocation");
        });

        modelBuilder.Entity<SpInventoryOpenReconcilation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_inventory_openReconcilation");

            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CFromTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_from_transport_unit_bk");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_started_at");
            entity.Property(e => e.Locationgroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("locationgroup");
            entity.Property(e => e.Parentlocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("parentlocation");
        });

        modelBuilder.Entity<SpInventoryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_inventory_report");

            entity.Property(e => e.Actualsystemstock)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("actualsystemstock");
            entity.Property(e => e.CCountType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_count_type");
            entity.Property(e => e.CCountedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_counted_at");
            entity.Property(e => e.CCountedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_counted_by");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CFinishedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_finished_at");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CQtyCounted)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_counted");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_started_at");
            entity.Property(e => e.Countedtu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("countedtu");
            entity.Property(e => e.Difference)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("difference");
            entity.Property(e => e.Inventorystate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("inventorystate");
            entity.Property(e => e.Locationgroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("locationgroup");
            entity.Property(e => e.Parentlocation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("parentlocation");
        });

        modelBuilder.Entity<SpLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_location");

            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDirectBookingAllowed).HasColumnName("c_direct_booking_allowed");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CIsActiveLocation).HasColumnName("c_is_active_location");
            entity.Property(e => e.CIsReceivingLocation).HasColumnName("c_is_receiving_location");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CLocationType).HasColumnName("c_location_type");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CMovementTarget).HasColumnName("c_movement_target");
            entity.Property(e => e.CNoInboundMovement).HasColumnName("c_no_inbound_movement");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CSplsDispo).HasColumnName("c_spls_dispo");
            entity.Property(e => e.Locationgroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("locationgroup");
        });

        modelBuilder.Entity<SpPickOrderPosWithShpOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_pickOrderPosWithShpOrder");

            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CSoureLocations)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("c_soure_locations");
            entity.Property(e => e.PopOrderPk).HasColumnName("pop_order_pk");
            entity.Property(e => e.PopOrderRef)
                .HasColumnType("text")
                .HasColumnName("pop_order_ref");
            entity.Property(e => e.PopPk).HasColumnName("pop_pk");
            entity.Property(e => e.PopPosId).HasColumnName("pop_pos_id");
            entity.Property(e => e.PopQtyPick).HasColumnName("pop_qty_pick");
            entity.Property(e => e.PopQtyPicked).HasColumnName("pop_qty_picked");
            entity.Property(e => e.PopState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pop_state");
            entity.Property(e => e.ProdDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prod_description");
            entity.Property(e => e.ProdPk).HasColumnName("prod_pk");
            entity.Property(e => e.ProdSku)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prod_sku");
            entity.Property(e => e.QtyShippingOrder).HasColumnName("qty_shipping_order");
            entity.Property(e => e.ShpOrderId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("shp_order_id");
            entity.Property(e => e.ShpPk).HasColumnName("shp_pk");
            entity.Property(e => e.ShpPosPk).HasColumnName("shp_pos_pk");
        });

        modelBuilder.Entity<SpStockEmptyPickLocationTu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_stock_empty_pick_location_tu");

            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CMovementTarget).HasColumnName("c_movement_target");
            entity.Property(e => e.CNoInboundMovement).HasColumnName("c_no_inbound_movement");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.CNumberPerTu).HasColumnName("c_number_per_tu");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CStackingFactor).HasColumnName("c_stacking_factor");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.Isdispo).HasColumnName("isdispo");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Locationdesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationdesc");
            entity.Property(e => e.Locationgrouploc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationgrouploc");
            entity.Property(e => e.MainLocationGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mainLocationGroup");
            entity.Property(e => e.Stock).HasColumnName("stock");
        });

        modelBuilder.Entity<SpStockList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_stock_list");

            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CSku)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.Isdispo).HasColumnName("isdispo");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Locationdesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationdesc");
            entity.Property(e => e.Locationgroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("locationgroup");
            entity.Property(e => e.Locationgrouploc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationgrouploc");
            entity.Property(e => e.Locationstate).HasColumnName("locationstate");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.Tustate)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tustate");
        });

        modelBuilder.Entity<SpStockListNolock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sp_stock_list_nolock");

            entity.Property(e => e.CArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CLocationType).HasColumnName("c_location_type");
            entity.Property(e => e.CMvmTransportorderPosId).HasColumnName("c_mvm_transportorder_pos_id");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.CNumberPerTu).HasColumnName("c_number_per_tu");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSku)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CStackingFactor).HasColumnName("c_stacking_factor");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.Isdispo).HasColumnName("isdispo");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.LocationPk).HasColumnName("location_pk");
            entity.Property(e => e.Locationdesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationdesc");
            entity.Property(e => e.Locationgrouploc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("locationgrouploc");
            entity.Property(e => e.MainLocationGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mainLocationGroup");
            entity.Property(e => e.ProductPk).HasColumnName("product_pk");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.TranportUnitPk).HasColumnName("tranportUnitPk");
        });

        modelBuilder.Entity<TempReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_report");

            entity.Property(e => e.CDate)
                .HasColumnType("date")
                .HasColumnName("c_date");
            entity.Property(e => e.CDesc)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("c_desc");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.COp)
                .HasColumnType("ntext")
                .HasColumnName("c_op");
            entity.Property(e => e.CQty).HasColumnName("c_qty");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CTu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_tu");
        });

        modelBuilder.Entity<Temptable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temptable");

            entity.Property(e => e.Erpcode)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("erpcode");
            entity.Property(e => e.Processed).HasColumnName("processed");
            entity.Property(e => e.Sortindex).HasColumnName("sortindex");
        });

        modelBuilder.Entity<WmsInvArticleLocationMap>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_article_location_map_pkey");

            entity.ToTable("wms_inv_article_location_map");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CLocationGroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group_name");
            entity.Property(e => e.CLocationPk).HasColumnName("c_location_pk");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CLocationPkNavigation).WithMany(p => p.WmsInvArticleLocationMaps)
                .HasForeignKey(d => d.CLocationPk)
                .HasConstraintName("fk_aol_loc_pk");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvArticleLocationMaps)
                .HasForeignKey(d => d.CProductPk)
                .HasConstraintName("fk_aol_product_pk");
        });

        modelBuilder.Entity<WmsInvDiscrepancy>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_discrepancy_pkey");

            entity.ToTable("wms_inv_discrepancy");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CApprovedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_approved_at");
            entity.Property(e => e.CApprovedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_approved_by");
            entity.Property(e => e.CCountedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_counted_at");
            entity.Property(e => e.CCountedBy)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_counted_by");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CLoadUnitPk).HasColumnName("c_load_unit_pk");
            entity.Property(e => e.CLocationPk).HasColumnName("c_location_pk");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQtyCounted)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_counted");
            entity.Property(e => e.CQtyCountedType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_counted_type");
            entity.Property(e => e.CQtyExpected)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_expected");
            entity.Property(e => e.CQtyExpectedType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_expected_type");
            entity.Property(e => e.CSenderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sender_id");
            entity.Property(e => e.CTraceId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_trace_id");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CLoadUnitPkNavigation).WithMany(p => p.WmsInvDiscrepancies)
                .HasForeignKey(d => d.CLoadUnitPk)
                .HasConstraintName("fk_disc_lu_pk");

            entity.HasOne(d => d.CLocationPkNavigation).WithMany(p => p.WmsInvDiscrepancies)
                .HasForeignKey(d => d.CLocationPk)
                .HasConstraintName("fk_disc_loc_pk");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvDiscrepancies)
                .HasForeignKey(d => d.CProductPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_disc_product_pk");
        });

        modelBuilder.Entity<WmsInvFillLevel>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_fill_level_pkey");

            entity.ToTable("wms_inv_fill_level");

            entity.HasIndex(e => new { e.CLocationPk, e.CAvState }, "uc_inv_fl_sku");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_account");
            entity.Property(e => e.CAvState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_av_state");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CLocationPk).HasColumnName("c_location_pk");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CQtyMax)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_max");
            entity.Property(e => e.CQtyMin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_min");
            entity.Property(e => e.CQtyTypeMax)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_max");
            entity.Property(e => e.CQtyTypeMin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_min");
            entity.Property(e => e.CSourceLocationGroups)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_source_location_groups");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CLocationPkNavigation).WithMany(p => p.WmsInvFillLevels)
                .HasForeignKey(d => d.CLocationPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_llpl_loc_pk");
        });

        modelBuilder.Entity<WmsInvFillup>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_fillup_pkey");

            entity.ToTable("wms_inv_fillup");

            entity.HasIndex(e => new { e.CSku, e.CAccount }, "uc_inv_fu_sku");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_account");
            entity.Property(e => e.CAvState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_av_state");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CLocationErpCode)
                .HasMaxLength(50)
                .HasColumnName("c_location_erp_code");
            entity.Property(e => e.CLocationTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_type_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CQtyCurrent)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_current");
            entity.Property(e => e.CQtyMax)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_max");
            entity.Property(e => e.CQtyMin)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_min");
            entity.Property(e => e.CQtyTypeCurrent)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_current");
            entity.Property(e => e.CQtyTypeMax)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_max");
            entity.Property(e => e.CQtyTypeMin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_min");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CSourceLocationGroups)
                .HasMaxLength(2048)
                .IsUnicode(false)
                .HasColumnName("c_source_location_groups");
            entity.Property(e => e.CTargetLocationGroup)
                .HasMaxLength(200)
                .HasColumnName("c_target_location_group");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsInvLoadUnit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_load_unit_pkey");

            entity.ToTable("wms_inv_load_unit");

            entity.HasIndex(e => new { e.CTransportUnitPk, e.CPhysicalPos }, "uc_lu_tupk_pos").IsUnique();

            entity.HasIndex(e => new { e.CPhysicalPos, e.CTransportUnitPk }, "wms_inv_load_unit_c_physical_pos_c_transport_unit_pk_index");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.CLoadUnitType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_load_unit_type");
            entity.Property(e => e.CLocked).HasColumnName("c_locked");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPhysicalPos)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_physical_pos");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CTransportUnitPk).HasColumnName("c_transport_unit_pk");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWidth).HasColumnName("c_width");

            entity.HasOne(d => d.CLoadUnitTypeNavigation).WithMany(p => p.WmsInvLoadUnits)
                .HasPrincipalKey(p => p.CType)
                .HasForeignKey(d => d.CLoadUnitType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lut_type");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvLoadUnits)
                .HasForeignKey(d => d.CProductPk)
                .HasConstraintName("fk_lu_product_pk");

            entity.HasOne(d => d.CTransportUnitPkNavigation).WithMany(p => p.WmsInvLoadUnits)
                .HasForeignKey(d => d.CTransportUnitPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lu_tu_pk");
        });

        modelBuilder.Entity<WmsInvLoadUnitLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_load_unit_log_pkey");

            entity.ToTable("wms_inv_load_unit_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.CLoadUnitType).HasColumnName("c_load_unit_type");
            entity.Property(e => e.CLocked).HasColumnName("c_locked");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CPhysicalPos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_physical_pos");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CTransportUnitPk).HasColumnName("c_transport_unit_pk");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWidth).HasColumnName("c_width");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvLoadUnitLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkm2po2n1yu8fsjcvl6nogv77u1");
        });

        modelBuilder.Entity<WmsInvLoadUnitType>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_load_unit_type_pkey");

            entity.ToTable("wms_inv_load_unit_type");

            entity.HasIndex(e => e.CType, "uc_lut_type").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CInnerHeight).HasColumnName("c_inner_height");
            entity.Property(e => e.CInnerLength).HasColumnName("c_inner_length");
            entity.Property(e => e.CInnerWidth).HasColumnName("c_inner_width");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COuterHeight).HasColumnName("c_outer_height");
            entity.Property(e => e.COuterLength).HasColumnName("c_outer_length");
            entity.Property(e => e.COuterWidth).HasColumnName("c_outer_width");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeightMax)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_max");
            entity.Property(e => e.CWeightMaxType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_max_type");
            entity.Property(e => e.CWeightTare)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_tare");
            entity.Property(e => e.CWeightTareType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_tare_type");
        });

        modelBuilder.Entity<WmsInvLocation>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_location_pkey");

            entity.ToTable("wms_inv_location");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAisle)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_aisle");
            entity.Property(e => e.CArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDirectBookingAllowed).HasColumnName("c_direct_booking_allowed");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CForeignPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CIsActiveLocation).HasColumnName("c_is_active_location");
            entity.Property(e => e.CIsReceivingLocation).HasColumnName("c_is_receiving_location");
            entity.Property(e => e.CIsTargetForMvm).HasColumnName("c_is_target_for_mvm");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CLastPickDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_pick_date");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CLocationType).HasColumnName("c_location_type");
            entity.Property(e => e.CMainLocationGroup)
                .HasMaxLength(50)
                .HasColumnName("c_main_location_group");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CMovementTarget).HasColumnName("c_movement_target");
            entity.Property(e => e.CNoInboundMovement).HasColumnName("c_no_inbound_movement");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CSplsDispo).HasColumnName("c_spls_dispo");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CX)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_x");
            entity.Property(e => e.CY)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_y");
            entity.Property(e => e.CZ)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_z");
        });

        modelBuilder.Entity<WmsInvLocationLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_location_log_pkey");

            entity.ToTable("wms_inv_location_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CAisle)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_aisle");
            entity.Property(e => e.CArea)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_area");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CForeignPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CIncomingActive).HasColumnName("c_incoming_active");
            entity.Property(e => e.CLastInventoryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_inventory_date");
            entity.Property(e => e.CLastPickDate)
                .HasColumnType("datetime")
                .HasColumnName("c_last_pick_date");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.CNoMaxTransportUnits).HasColumnName("c_no_max_transport_units");
            entity.Property(e => e.COutgoingActive).HasColumnName("c_outgoing_active");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPlcState).HasColumnName("c_plc_state");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CX)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_x");
            entity.Property(e => e.CY)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_y");
            entity.Property(e => e.CZ)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("c_z");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvLocationLogs)
                .HasForeignKey(d => d.CRev)
                .HasConstraintName("fk3l03d64363600clx5swd3nj4q");
        });

        modelBuilder.Entity<WmsInvLocationType>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_location_type_pkey");

            entity.ToTable("wms_inv_location_type");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWidth).HasColumnName("c_width");
        });

        modelBuilder.Entity<WmsInvOrderReference>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_order_reference_pk");

            entity.ToTable("wms_inv_order_reference");

            entity.HasIndex(e => e.CPopPk, "wms_inv_order_reference_c_pop_pk_index");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CConfirmed).HasColumnName("c_confirmed");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CForeignId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_id");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPopPk).HasColumnName("c_pop_pk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CPopPkNavigation).WithMany(p => p.WmsInvOrderReferences)
                .HasForeignKey(d => d.CPopPk)
                .HasConstraintName("fk_pop_or");
        });

        modelBuilder.Entity<WmsInvPackagingUnit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_packaging_unit_pkey");

            entity.ToTable("wms_inv_packaging_unit");

            entity.HasIndex(e => new { e.CAvState, e.CProductPk }, "IX_PU_STATE_PRODUCT");

            entity.HasIndex(e => e.CAvState, "sp_db_pu_ix");

            entity.HasIndex(e => e.CActualLocation, "wms_inv_packaging_unit_c_actual_location_index");

            entity.HasIndex(e => e.CPid, "wms_inv_packaging_unit_c_pid_index");

            entity.HasIndex(e => new { e.CPk, e.COl }, "wms_inv_packaging_unit_c_pk_c_ol_index");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CActualLocation).HasColumnName("c_actual_location");
            entity.Property(e => e.CAlive).HasColumnName("c_alive");
            entity.Property(e => e.CAvState)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_av_state");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("c_expires_at");
            entity.Property(e => e.CFifoDate)
                .HasColumnType("datetime")
                .HasColumnName("c_fifo_date");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLabels)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_labels");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.CLoadUnit).HasColumnName("c_load_unit");
            entity.Property(e => e.CLotId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_lot_id");
            entity.Property(e => e.CLotPkey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_lot_pkey");
            entity.Property(e => e.CMessageNo).HasColumnName("c_message_no");
            entity.Property(e => e.CMessageText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_message_text");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CParent).HasColumnName("c_parent");
            entity.Property(e => e.CPhysicalPos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_physical_pos");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQty).HasColumnName("c_qty");
            entity.Property(e => e.CQtyType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type");
            entity.Property(e => e.CSerialNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_serial_number");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight");
            entity.Property(e => e.CWeightType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_type");
            entity.Property(e => e.CWidth).HasColumnName("c_width");
            entity.Property(e => e.PhysicalPosition)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("physical_position");

            entity.HasOne(d => d.CActualLocationNavigation).WithMany(p => p.WmsInvPackagingUnits)
                .HasForeignKey(d => d.CActualLocation)
                .HasConstraintName("fk_pu_loc_pk");

            entity.HasOne(d => d.CLoadUnitNavigation).WithMany(p => p.WmsInvPackagingUnits)
                .HasForeignKey(d => d.CLoadUnit)
                .HasConstraintName("fk_lu_pk");

            entity.HasOne(d => d.CParentNavigation).WithMany(p => p.InverseCParentNavigation)
                .HasForeignKey(d => d.CParent)
                .HasConstraintName("fk_pu_pu_parent");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvPackagingUnits)
                .HasForeignKey(d => d.CProductPk)
                .HasConstraintName("fk_pu_product_pk");
        });

        modelBuilder.Entity<WmsInvPackagingUnitLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_packaging_unit_log_pkey");

            entity.ToTable("wms_inv_packaging_unit_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CActualLocation).HasColumnName("c_actual_location");
            entity.Property(e => e.CAlive).HasColumnName("c_alive");
            entity.Property(e => e.CAvState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_av_state");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CExpiresAt)
                .HasColumnType("datetime")
                .HasColumnName("c_expires_at");
            entity.Property(e => e.CFifoDate)
                .HasColumnType("datetime")
                .HasColumnName("c_fifo_date");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLabels)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_labels");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.CLoadUnit).HasColumnName("c_load_unit");
            entity.Property(e => e.CLotId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_lot_id");
            entity.Property(e => e.CLotPkey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_lot_pkey");
            entity.Property(e => e.CMessageNo).HasColumnName("c_message_no");
            entity.Property(e => e.CMessageText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_message_text");
            entity.Property(e => e.CParent).HasColumnName("c_parent");
            entity.Property(e => e.CPhysicalPos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_physical_pos");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQty)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty");
            entity.Property(e => e.CQtyType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CSerialNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_serial_number");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight");
            entity.Property(e => e.CWeightType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_type");
            entity.Property(e => e.CWidth).HasColumnName("c_width");
            entity.Property(e => e.PhysicalPosition)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("physical_position");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvPackagingUnitLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkorslxj6jole226itq5c7cy8ax");
        });

        modelBuilder.Entity<WmsInvPickDetail>(entity =>
        {
            entity.HasKey(e => new { e.COrderPk, e.CKey }).HasName("wms_inv_pick_detail_pkey");

            entity.ToTable("wms_inv_pick_detail");

            entity.Property(e => e.COrderPk).HasColumnName("c_order_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");

            entity.HasOne(d => d.COrderPkNavigation).WithMany(p => p.WmsInvPickDetails)
                .HasForeignKey(d => d.COrderPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_details_po");
        });

        modelBuilder.Entity<WmsInvPickDetailLog>(entity =>
        {
            entity.HasKey(e => new { e.CRev, e.COrderPk, e.CValue, e.CKey }).HasName("wms_inv_pick_detail_log_pkey");

            entity.ToTable("wms_inv_pick_detail_log");

            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.COrderPk).HasColumnName("c_order_pk");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvPickDetailLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkkwosus082ijwpjwm3q3qriff5");
        });

        modelBuilder.Entity<WmsInvPickOrder>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_pick_order_pkey");

            entity.ToTable("wms_inv_pick_order");

            entity.HasIndex(e => new { e.COrderType, e.CSourceLocationGroup, e.CState, e.CEarliestStartedAt }, "sp_ix_pickorder");

            entity.HasIndex(e => e.COrderId, "uc_po_id").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAssignedUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_assigned_user");
            entity.Property(e => e.CCdcTag)
                .HasMaxLength(50)
                .HasColumnName("c_cdc_tag");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDropLocationPk).HasColumnName("c_drop_location_pk");
            entity.Property(e => e.CEarliestStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_earliest_started_at");
            entity.Property(e => e.CFinishedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_finished_at");
            entity.Property(e => e.CNote)
                .HasMaxLength(200)
                .HasColumnName("c_note");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_type");
            entity.Property(e => e.CPickUserGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pick_user_group");
            entity.Property(e => e.CPickupDate)
                .HasColumnType("date")
                .HasColumnName("c_pickup_date");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CShared).HasColumnName("c_shared");
            entity.Property(e => e.CShipper)
                .HasMaxLength(50)
                .HasColumnName("c_shipper");
            entity.Property(e => e.CShippingDateTo)
                .HasColumnType("date")
                .HasColumnName("c_shipping_date_to");
            entity.Property(e => e.CSourceLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_source_location_group");
            entity.Property(e => e.CStartMode)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_start_mode");
            entity.Property(e => e.CStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_started_at");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTitle)
                .HasMaxLength(50)
                .HasColumnName("c_title");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");

            entity.HasOne(d => d.CDropLocationPkNavigation).WithMany(p => p.WmsInvPickOrders)
                .HasForeignKey(d => d.CDropLocationPk)
                .HasConstraintName("fk_po_drop_location");
        });

        modelBuilder.Entity<WmsInvPickOrderId>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_pick_order_id_pkey");

            entity.ToTable("wms_inv_pick_order_id");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCurrent)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("c_current");
            entity.Property(e => e.CName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPrefix)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_prefix");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsInvPickOrderLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_pick_order_log_pkey");

            entity.ToTable("wms_inv_pick_order_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDropLocationPk).HasColumnName("c_drop_location_pk");
            entity.Property(e => e.CEarliestStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_earliest_started_at");
            entity.Property(e => e.CFinishedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_finished_at");
            entity.Property(e => e.COrderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_type");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CShared).HasColumnName("c_shared");
            entity.Property(e => e.CSourceLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_source_location_group");
            entity.Property(e => e.CStartMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_start_mode");
            entity.Property(e => e.CStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_started_at");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvPickOrderLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkjcg6qe9q3woa9f8piv4patj8d");
        });

        modelBuilder.Entity<WmsInvPickOrderPosReference>(entity =>
        {
            entity.HasKey(e => e.CPk);

            entity.ToTable("wms_inv_pick_order_pos_references");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CConfirmed).HasColumnName("c_confirmed");
            entity.Property(e => e.CPickOrderPk).HasColumnName("c_pick_order_pk");
            entity.Property(e => e.CPickOrderPosPk).HasColumnName("c_pick_order_pos_pk");
            entity.Property(e => e.CShpOrderPk).HasColumnName("c_shp_order_pk");
            entity.Property(e => e.CShpOrderPosPk).HasColumnName("c_shp_order_pos_pk");
        });

        modelBuilder.Entity<WmsInvPickOrderPosSplit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_pick_order_pos_split_pkey");

            entity.ToTable("wms_inv_pick_order_pos_split");

            entity.HasIndex(e => e.CState, "IX_SP_SPLIT_STATE");

            entity.HasIndex(e => new { e.CPositionPk, e.CSplitNo }, "uc_pps").IsUnique();

            entity.HasIndex(e => e.CPid, "wms_inv_pick_order_pos_split_c_pid_index");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CFromTransportunitPk).HasColumnName("c_from_transportunit_pk");
            entity.Property(e => e.CLoadUnitPos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_load_unit_pos");
            entity.Property(e => e.CLocationPk).HasColumnName("c_location_pk");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderRef)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_ref");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPositionPk).HasColumnName("c_position_pk");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CProdutctPk).HasColumnName("c_produtct_pk");
            entity.Property(e => e.CQtyPicked).HasColumnName("c_qty_picked");
            entity.Property(e => e.CQtyPosPick).HasColumnName("c_qty_pos_pick");
            entity.Property(e => e.CQtyReserved).HasColumnName("c_qty_reserved");
            entity.Property(e => e.CQtyToPick).HasColumnName("c_qty_to_pick");
            entity.Property(e => e.CQtyTypePick)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_pick");
            entity.Property(e => e.CQtyTypeReserved)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_reserved");
            entity.Property(e => e.CShpOrderPk).HasColumnName("c_shp_order_pk");
            entity.Property(e => e.CShpOrderPosPk).HasColumnName("c_shp_order_pos_pk");
            entity.Property(e => e.CSplitNo).HasColumnName("c_split_no");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CToTransportunitPk).HasColumnName("c_to_transportunit_pk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CFromTransportunitPkNavigation).WithMany(p => p.WmsInvPickOrderPosSplitCFromTransportunitPkNavigations)
                .HasForeignKey(d => d.CFromTransportunitPk)
                .HasConstraintName("fk_pps_from_tu");

            entity.HasOne(d => d.CLocationPkNavigation).WithMany(p => p.WmsInvPickOrderPosSplits)
                .HasForeignKey(d => d.CLocationPk)
                .HasConstraintName("fk_pps_location");

            entity.HasOne(d => d.CPositionPkNavigation).WithMany(p => p.WmsInvPickOrderPosSplits)
                .HasForeignKey(d => d.CPositionPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pps_pos");

            entity.HasOne(d => d.CToTransportunitPkNavigation).WithMany(p => p.WmsInvPickOrderPosSplitCToTransportunitPkNavigations)
                .HasForeignKey(d => d.CToTransportunitPk)
                .HasConstraintName("fk_pps_to_tu");
        });

        modelBuilder.Entity<WmsInvPickOrderPosSplitLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_pick_order_pos_split_log_pkey");

            entity.ToTable("wms_inv_pick_order_pos_split_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CFromTransportunitPk).HasColumnName("c_from_transportunit_pk");
            entity.Property(e => e.CListPositionPk).HasColumnName("c_list_position_pk");
            entity.Property(e => e.CLoadUnitPos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_load_unit_pos");
            entity.Property(e => e.CLocationPk).HasColumnName("c_location_pk");
            entity.Property(e => e.COrderRef)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_ref");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPositionPk).HasColumnName("c_position_pk");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CQtyPick)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_pick");
            entity.Property(e => e.CQtyReserved)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_reserved");
            entity.Property(e => e.CQtyTypePick)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_pick");
            entity.Property(e => e.CQtyTypeReserved)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_reserved");
            entity.Property(e => e.CReservationId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_reservation_id");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CSplitNo).HasColumnName("c_split_no");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CToLoadUnitPos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_to_load_unit_pos");
            entity.Property(e => e.CToTransportunitPk).HasColumnName("c_to_transportunit_pk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvPickOrderPosSplitLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkdx3808fbbpy0g1r8nrksm77x1");
        });

        modelBuilder.Entity<WmsInvPickOrderPosition>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_pick_order_position_pkey");

            entity.ToTable("wms_inv_pick_order_position");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCustomerOrderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_order_id");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CNextAllocation)
                .HasColumnType("datetime")
                .HasColumnName("c_next_allocation");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderPk).HasColumnName("c_order_pk");
            entity.Property(e => e.COrderRef)
                .HasColumnType("text")
                .HasColumnName("c_order_ref");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPositionId).HasColumnName("c_position_id");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQtyOnError)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_on_error");
            entity.Property(e => e.CQtyPick).HasColumnName("c_qty_pick");
            entity.Property(e => e.CQtyPicked).HasColumnName("c_qty_picked");
            entity.Property(e => e.CQtyTypeOnError)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_on_error");
            entity.Property(e => e.CQtyTypePick)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_pick");
            entity.Property(e => e.CSourceLocationGroups)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_source_location_groups");
            entity.Property(e => e.CSoureLocations)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("c_soure_locations");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");

            entity.HasOne(d => d.COrderPkNavigation).WithMany(p => p.WmsInvPickOrderPositions)
                .HasForeignKey(d => d.COrderPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pp_order");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvPickOrderPositions)
                .HasForeignKey(d => d.CProductPk)
                .HasConstraintName("fk_pp_product");
        });

        modelBuilder.Entity<WmsInvPickOrderPositionLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_pick_order_position_log_pkey");

            entity.ToTable("wms_inv_pick_order_position_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCustomerOrderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_order_id");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CNextAllocation)
                .HasColumnType("datetime")
                .HasColumnName("c_next_allocation");
            entity.Property(e => e.COrderPk).HasColumnName("c_order_pk");
            entity.Property(e => e.COrderRef)
                .HasColumnType("text")
                .HasColumnName("c_order_ref");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPositionId).HasColumnName("c_position_id");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQtyOnError)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_on_error");
            entity.Property(e => e.CQtyPick)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_pick");
            entity.Property(e => e.CQtyTypeOnError)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_on_error");
            entity.Property(e => e.CQtyTypePick)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_pick");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CSourceLocationGroups)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_source_location_groups");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvPickOrderPositionLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkeqw8ahvug5rqil78wlfoqx4i");
        });

        modelBuilder.Entity<WmsInvPickOrderTu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wms_inv_pick_order_tu");

            entity.HasIndex(e => e.CTuPk, "uk_83ogoxpgg12ytkfu77imrd582").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CTuPk).HasColumnName("c_tu_pk");

            entity.HasOne(d => d.CPkNavigation).WithMany()
                .HasForeignKey(d => d.CPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_po_tu_pk");

            entity.HasOne(d => d.CTuPkNavigation).WithOne()
                .HasForeignKey<WmsInvPickOrderTu>(d => d.CTuPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tu_po_pk");
        });

        modelBuilder.Entity<WmsInvPickOrderTuLog>(entity =>
        {
            entity.HasKey(e => new { e.CRev, e.CPk, e.CTuPk }).HasName("wms_inv_pick_order_tu_log_pkey");

            entity.ToTable("wms_inv_pick_order_tu_log");

            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CTuPk).HasColumnName("c_tu_pk");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvPickOrderTuLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fknh5nfr0rcxn9xkp3y10rs5spf");
        });

        modelBuilder.Entity<WmsInvPickOrderTuReference>(entity =>
        {
            entity.HasKey(e => e.CPk);

            entity.ToTable("wms_inv_pick_order_tu_references");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CConfirmed).HasColumnName("c_confirmed");
            entity.Property(e => e.CFull).HasColumnName("c_full");
            entity.Property(e => e.CPickOrderPk).HasColumnName("c_pick_order_pk");
            entity.Property(e => e.CShpOrderPk).HasColumnName("c_shp_order_pk");
            entity.Property(e => e.CTranportUnitPk).HasColumnName("c_tranport_unit_pk");
        });

        modelBuilder.Entity<WmsInvProduct>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_product_pkey");

            entity.ToTable("wms_inv_product");

            entity.HasIndex(e => e.CSku, "uc_inv_product_sku").IsUnique();

            entity.HasIndex(e => e.CSku, "wms_inv_product_c_sku_index");

            entity.HasIndex(e => e.CSku, "wms_inv_product_sku");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_account");
            entity.Property(e => e.CAvState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_av_state");
            entity.Property(e => e.CBaseUnitQty)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_base_unit_qty");
            entity.Property(e => e.CBaseUnitType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_base_unit_type");
            entity.Property(e => e.CBasicTuType)
                .HasMaxLength(50)
                .HasColumnName("c_basic_tu_type");
            entity.Property(e => e.CClassification)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_classification");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDescription2)
                .HasMaxLength(255)
                .HasColumnName("c_description2");
            entity.Property(e => e.CDescriptionText)
                .HasColumnType("text")
                .HasColumnName("c_description_text");
            entity.Property(e => e.CGf01).HasColumnName("c_gf01");
            entity.Property(e => e.CGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group");
            entity.Property(e => e.CHeight)
                .HasColumnType("money")
                .HasColumnName("c_height");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CLeEinzeln)
                .HasMaxLength(10)
                .HasColumnName("c_le_einzeln");
            entity.Property(e => e.CLength)
                .HasColumnType("money")
                .HasColumnName("c_length");
            entity.Property(e => e.CNumberOfLayers).HasColumnName("c_number_of_layers");
            entity.Property(e => e.CNumberPerTu).HasColumnName("c_number_per_tu");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPickingInfo)
                .HasMaxLength(200)
                .HasColumnName("c_pickingInfo");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPiecesPerLayer).HasColumnName("c_pieces_per_layer");
            entity.Property(e => e.CPreferableStorageLocation).HasColumnName("c_preferable_storage_location");
            entity.Property(e => e.CSingleMaxTransportUnits).HasColumnName("c_single_max_transport_units");
            entity.Property(e => e.CSku)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CStackingFactor).HasColumnName("c_stacking_factor");
            entity.Property(e => e.CStockZone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_stock_zone");
            entity.Property(e => e.CTransportUnitHeight)
                .HasColumnType("money")
                .HasColumnName("c_transport_unit_height");
            entity.Property(e => e.CTransportUnitLength)
                .HasColumnType("money")
                .HasColumnName("c_transport_unit_length");
            entity.Property(e => e.CTransportUnitText)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_text");
            entity.Property(e => e.CTransportUnitWeight)
                .HasColumnType("money")
                .HasColumnName("c_transport_unit_weight");
            entity.Property(e => e.CTransportUnitWidth)
                .HasColumnType("money")
                .HasColumnName("c_transport_unit_width");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasColumnType("money")
                .HasColumnName("c_weight");
            entity.Property(e => e.CWeightGross)
                .HasColumnType("money")
                .HasColumnName("c_weight_gross");
            entity.Property(e => e.CWeightType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_type");
            entity.Property(e => e.CWidth)
                .HasColumnType("money")
                .HasColumnName("c_width");

            entity.HasOne(d => d.CPreferableStorageLocationNavigation).WithMany(p => p.WmsInvProducts)
                .HasForeignKey(d => d.CPreferableStorageLocation)
                .HasConstraintName("fk_prod_loc_pk");
        });

        modelBuilder.Entity<WmsInvProductDetail>(entity =>
        {
            entity.HasKey(e => new { e.CProductPk, e.CKey }).HasName("wms_inv_product_detail_pkey");

            entity.ToTable("wms_inv_product_detail");

            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvProductDetails)
                .HasForeignKey(d => d.CProductPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_details_product");
        });

        modelBuilder.Entity<WmsInvProductLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_product_log_pkey");

            entity.ToTable("wms_inv_product_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CAccount)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_account");
            entity.Property(e => e.CAvState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_av_state");
            entity.Property(e => e.CBaseUnitQty)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_base_unit_qty");
            entity.Property(e => e.CBaseUnitType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_base_unit_type");
            entity.Property(e => e.CClassification)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_classification");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDescriptionText)
                .HasColumnType("text")
                .HasColumnName("c_description_text");
            entity.Property(e => e.CGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_group");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPreferableStorageLocation).HasColumnName("c_preferable_storage_location");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CStockZone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_stock_zone");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_weight");
            entity.Property(e => e.CWeightType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight_type");
            entity.Property(e => e.CWidth).HasColumnName("c_width");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvProductLogs)
                .HasForeignKey(d => d.CRev)
                .HasConstraintName("fkohnu07jp5ap56k4v5miwck3gp");
        });

        modelBuilder.Entity<WmsInvProductStackingRule>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_product_stacking_rule_pkey");

            entity.ToTable("wms_inv_product_stacking_rule");

            entity.HasIndex(e => new { e.CBaseProduct, e.CAllowedProduct }, "uc_prodstrule").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CAllowedProduct).HasColumnName("c_allowed_product");
            entity.Property(e => e.CBaseProduct).HasColumnName("c_base_product");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CNoProducts).HasColumnName("c_no_products");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CAllowedProductNavigation).WithMany(p => p.WmsInvProductStackingRuleCAllowedProductNavigations)
                .HasForeignKey(d => d.CAllowedProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_psr_ap_product");

            entity.HasOne(d => d.CBaseProductNavigation).WithMany(p => p.WmsInvProductStackingRuleCBaseProductNavigations)
                .HasForeignKey(d => d.CBaseProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_psr_bp_product");
        });

        modelBuilder.Entity<WmsInvProductUnit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_product_unit_pkey");

            entity.ToTable("wms_inv_product_unit");

            entity.HasIndex(e => new { e.CProductPk, e.CLabel }, "uc_inv_punit_ppk_label").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQty)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty");
            entity.Property(e => e.CQtyType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type");
            entity.Property(e => e.CUom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_uom");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWidth).HasColumnName("c_width");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvProductUnits)
                .HasForeignKey(d => d.CProductPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_punit_product");
        });

        modelBuilder.Entity<WmsInvProductUnitDetail>(entity =>
        {
            entity.HasKey(e => new { e.CProductUnitPk, e.CKey }).HasName("wms_inv_product_unit_detail_pkey");

            entity.ToTable("wms_inv_product_unit_detail");

            entity.Property(e => e.CProductUnitPk).HasColumnName("c_product_unit_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");

            entity.HasOne(d => d.CProductUnitPkNavigation).WithMany(p => p.WmsInvProductUnitDetails)
                .HasForeignKey(d => d.CProductUnitPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_details_product_unit");
        });

        modelBuilder.Entity<WmsInvProductZone>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_product_zone_pkey");

            entity.ToTable("wms_inv_product_zone");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CLocationGroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPosition).HasColumnName("c_position");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsInvProductZones)
                .HasForeignKey(d => d.CProductPk)
                .HasConstraintName("fk_pzm_product_pk");
        });

        modelBuilder.Entity<WmsInvReservation>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_reservation_pkey");

            entity.ToTable("wms_inv_reservation");

            entity.HasIndex(e => e.CReservedBy, "wms_inv_reservation_c_reserved_by_index");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPackagingUnitPk).HasColumnName("c_packaging_unit_pk");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CQtyReserved)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_reserved");
            entity.Property(e => e.CQtyTypeReserved)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_reserved");
            entity.Property(e => e.CReservedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_reserved_at");
            entity.Property(e => e.CReservedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_reserved_by");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CPackagingUnitPkNavigation).WithMany(p => p.WmsInvReservations)
                .HasForeignKey(d => d.CPackagingUnitPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pureservation_pk");
        });

        modelBuilder.Entity<WmsInvReservationLog>(entity =>
        {
            entity.HasKey(e => new { e.CPk, e.CRev }).HasName("wms_inv_reservation_log_pkey");

            entity.ToTable("wms_inv_reservation_log");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CRev).HasColumnName("c_rev");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CPackagingUnitPk).HasColumnName("c_packaging_unit_pk");
            entity.Property(e => e.CPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CQtyReserved)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_reserved");
            entity.Property(e => e.CQtyTypeReserved)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_reserved");
            entity.Property(e => e.CReservedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_reserved_at");
            entity.Property(e => e.CReservedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_reserved_by");
            entity.Property(e => e.CRevType).HasColumnName("c_rev_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CRevNavigation).WithMany(p => p.WmsInvReservationLogs)
                .HasForeignKey(d => d.CRev)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk33u5lgnhso12itvwasgvrvkno");
        });

        modelBuilder.Entity<WmsInvRevision>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_revision_pkey");

            entity.ToTable("wms_inv_revision");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CTimestamp).HasColumnName("c_timestamp");
            entity.Property(e => e.CTraceId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_trace_id");
            entity.Property(e => e.CUser)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_user");
        });

        modelBuilder.Entity<WmsInvTask>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_task_pkey");

            entity.ToTable("wms_inv_task");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDisc)
                .IsRequired()
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("c_disc");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CustomerOrderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("customer_order_id");
            entity.Property(e => e.LoadUnitType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("load_unit_type");
            entity.Property(e => e.Parts).HasColumnName("parts");
            entity.Property(e => e.TransportUnitbk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("transport_unitbk");
        });

        modelBuilder.Entity<WmsInvTransaction>(entity =>
        {
            entity.ToTable("wms_inv_transactions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CallerId).HasMaxLength(50);
            entity.Property(e => e.CallerType).HasMaxLength(50);
            entity.Property(e => e.OrderId).HasMaxLength(50);
            entity.Property(e => e.Sku).HasMaxLength(50);
            entity.Property(e => e.SourceLocation).HasMaxLength(50);
            entity.Property(e => e.SourceTu).HasMaxLength(50);
            entity.Property(e => e.TargetLocation).HasMaxLength(50);
            entity.Property(e => e.TargetTu).HasMaxLength(50);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<WmsInvTransportUnit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_inv_transport_unit_pkey");

            entity.ToTable("wms_inv_transport_unit");

            entity.HasIndex(e => e.CTransportUnitBk, "wms_inv_transport_unit_c_transport_unit_bk_index");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAcknowledged).HasColumnName("c_acknowledged");
            entity.Property(e => e.CActualLocation).HasColumnName("c_actual_location");
            entity.Property(e => e.CActualLocationDate)
                .HasColumnType("datetime")
                .HasColumnName("c_actual_location_date");
            entity.Property(e => e.CAddWeight).HasColumnName("c_add_weight");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCustomerOrderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_order_id");
            entity.Property(e => e.CErpOrderSourceId)
                .HasMaxLength(50)
                .HasColumnName("c_erp_order_source_id");
            entity.Property(e => e.CForeignPid)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CHeight).HasColumnName("c_height");
            entity.Property(e => e.CLength).HasColumnName("c_length");
            entity.Property(e => e.CMvmTransportorderPosId).HasColumnName("c_mvm_transportorder_pos_id");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CReconciledAt)
                .HasColumnType("datetime")
                .HasColumnName("c_reconciled_at");
            entity.Property(e => e.CReconciledBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_reconciled_by");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTarget)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target");
            entity.Property(e => e.CTransportUnitBk)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.CTransportUnitType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWidth).HasColumnName("c_width");

            entity.HasOne(d => d.CActualLocationNavigation).WithMany(p => p.WmsInvTransportUnits)
                .HasForeignKey(d => d.CActualLocation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_loc_pk");
        });

        modelBuilder.Entity<WmsMvmTransportorder>(entity =>
        {
            entity.HasKey(e => e.CPk);

            entity.ToTable("wms_mvm_transportorder");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCountry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_country");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCustomerGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_group");
            entity.Property(e => e.CCustomerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_name");
            entity.Property(e => e.CCustomerNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_no");
            entity.Property(e => e.CDeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("c_delivery_date");
            entity.Property(e => e.CErpOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_erp_order_id");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CMyfactoryOrderNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_myfactory_order_number");
            entity.Property(e => e.COrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_source");
            entity.Property(e => e.COrderState)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_state");
            entity.Property(e => e.COrdertype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_ordertype");
            entity.Property(e => e.CPickUpDate)
                .HasColumnType("datetime")
                .HasColumnName("c_pick_up_date");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CShipper)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_shipper");
            entity.Property(e => e.CShippingType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_shipping_type");
            entity.Property(e => e.CSourceLocationGroup)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_source_location_group");
            entity.Property(e => e.CSplitDelivery).HasColumnName("c_split_delivery");
            entity.Property(e => e.CStartDate)
                .HasColumnType("datetime")
                .HasColumnName("c_start_date");
            entity.Property(e => e.CStartMode)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_start_mode");
            entity.Property(e => e.CTargetLocation)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_location");
            entity.Property(e => e.CTargetLocationGroup)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_location_group");
            entity.Property(e => e.CTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_title");
            entity.Property(e => e.CWeight)
                .HasColumnType("money")
                .HasColumnName("c_weight");
        });

        modelBuilder.Entity<WmsMvmTransportorderPosition>(entity =>
        {
            entity.HasKey(e => e.CPk);

            entity.ToTable("wms_mvm_transportorder_position");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_message");
            entity.Property(e => e.COrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderState)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_state");
            entity.Property(e => e.CPositionNo).HasColumnName("c_position_no");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQtyOrdered).HasColumnName("c_qty_ordered");
            entity.Property(e => e.CQtyShipped).HasColumnName("c_qty_shipped");
            entity.Property(e => e.CTransportorderPk).HasColumnName("c_transportorder_pk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CTransportorderPkNavigation).WithMany(p => p.WmsMvmTransportorderPositions)
                .HasForeignKey(d => d.CTransportorderPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_wms_mvm_transportorder_position_wms_mvm_transportorder");
        });

        modelBuilder.Entity<WmsRecOrder>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_rec_order_pkey");

            entity.ToTable("wms_rec_order");

            entity.HasIndex(e => e.COrderId, "uc_rec_order_id").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CContainerNumber)
                .HasMaxLength(50)
                .HasColumnName("c_container_number");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CEndDate)
                .HasColumnType("datetime")
                .HasColumnName("c_end_date");
            entity.Property(e => e.CExpectedReceipt)
                .HasColumnType("datetime")
                .HasColumnName("c_expected_receipt");
            entity.Property(e => e.CExternalConfirmed).HasColumnName("c_external_confirmed");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CLocked).HasColumnName("c_locked");
            entity.Property(e => e.CMvmTransportorderPk).HasColumnName("c_mvm_transportorder_pk");
            entity.Property(e => e.CNextAlloc)
                .HasColumnType("datetime")
                .HasColumnName("c_next_alloc");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_state");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CStartDate)
                .HasColumnType("datetime")
                .HasColumnName("c_start_date");
            entity.Property(e => e.CStartEarliest)
                .HasColumnType("datetime")
                .HasColumnName("c_start_earliest");
            entity.Property(e => e.CSupplierNumber)
                .HasMaxLength(100)
                .HasColumnName("c_supplier_number");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsRecOrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.COrderPk, e.CKey }).HasName("wms_rec_order_detail_pkey");

            entity.ToTable("wms_rec_order_detail");

            entity.Property(e => e.COrderPk).HasColumnName("c_order_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");

            entity.HasOne(d => d.COrderPkNavigation).WithMany(p => p.WmsRecOrderDetails)
                .HasForeignKey(d => d.COrderPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_details_ro");
        });

        modelBuilder.Entity<WmsRecOrderId>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_rec_order_id_pkey");

            entity.ToTable("wms_rec_order_id");

            entity.HasIndex(e => e.CName, "ukrf4hnyiar5ke1k1fix3nep6ov").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCurrent)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("c_current");
            entity.Property(e => e.CName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPrefix)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_prefix");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsRecOrderPosition>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_rec_order_position_pkey");

            entity.ToTable("wms_rec_order_position");

            entity.HasIndex(e => new { e.COrderId, e.CPosNo }, "uc_order_id_pos").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCustomerOrderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customerOrderId");
            entity.Property(e => e.CDisc)
                .IsRequired()
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("c_disc");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CMvmTransportorderPosId).HasColumnName("c_mvm_transportorder_pos_id");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.CPosNo).HasColumnName("c_pos_no");
            entity.Property(e => e.CQtyExpected).HasColumnName("c_qty_expected");
            entity.Property(e => e.CQtyExpectedType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_expected_type");
            entity.Property(e => e.CQtyReceived).HasColumnName("c_qty_received");
            entity.Property(e => e.CQtyReceivedType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_received_type");
            entity.Property(e => e.CQtyTuAktion).HasColumnName("c_qty_tu_aktion");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CSourceLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_source_location_group");
            entity.Property(e => e.CState)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTargetLocation).HasColumnName("c_target_location");
            entity.Property(e => e.CTargetLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_location_group");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.CTransportUnitTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_type_name");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.COrder).WithMany(p => p.WmsRecOrderPositions)
                .HasPrincipalKey(p => p.COrderId)
                .HasForeignKey(d => d.COrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rec_pos_order_id");
        });

        modelBuilder.Entity<WmsRecOrderPositionDetail>(entity =>
        {
            entity.HasKey(e => new { e.COrderPosPk, e.CKey }).HasName("wms_rec_order_position_detail_pkey");

            entity.ToTable("wms_rec_order_position_detail");

            entity.Property(e => e.COrderPosPk).HasColumnName("c_order_pos_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");
        });

        modelBuilder.Entity<WmsRecOrderPostionErp>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("wms_rec_order_postion_erp");

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.CErpSubmitted).HasColumnName("c_erp_submitted");
            entity.Property(e => e.CErpType).HasColumnName("c_erp_type");
            entity.Property(e => e.COrderId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("c_order_id");
            entity.Property(e => e.CPosNo).HasColumnName("c_pos_no");
            entity.Property(e => e.CQtyReceived).HasColumnName("c_qty_received");
            entity.Property(e => e.CSku)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("c_sku");
        });

        modelBuilder.Entity<WmsRecProduct>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_rec_product_pkey");

            entity.ToTable("wms_rec_product");

            entity.HasIndex(e => e.CForeignPid, "uc_rec_product_foreign_pid").IsUnique();

            entity.HasIndex(e => e.CSku, "uc_rec_product_sku").IsUnique();

            entity.HasIndex(e => e.CSku, "wms_rec_product_sku");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CBaseUnitQty)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_base_unit_qty");
            entity.Property(e => e.CBaseUnitType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_base_unit_type");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CForeignPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsRecTransportUnit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_rec_transport_unit_pkey");

            entity.ToTable("wms_rec_transport_unit");

            entity.HasIndex(e => e.CForeignPid, "uc_rec_tu_foreign_pid").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CActualLocation)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_actual_location");
            entity.Property(e => e.CBarcode)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_barcode");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CForeignPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsReplenishmentReason>(entity =>
        {
            entity.HasKey(e => e.CPk);

            entity.ToTable("wms_replenishment_reason");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CReason)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("c_reason");
        });

        modelBuilder.Entity<WmsReport>(entity =>
        {
            entity.HasKey(e => e.CId);

            entity.ToTable("wms_reports");

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.CReportJsonScheme).HasColumnName("c_report_json_scheme");
            entity.Property(e => e.CReportLayoutData)
                .IsRequired()
                .HasColumnName("c_report_layout_data");
            entity.Property(e => e.CReportName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("c_report_name");
        });

        modelBuilder.Entity<WmsShipmentType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wms_shipment_types");

            entity.Property(e => e.CId)
                .ValueGeneratedOnAdd()
                .HasColumnName("c_id");
            entity.Property(e => e.CShipperName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("c_shipper_name");
        });

        modelBuilder.Entity<WmsShipper>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wms_shipper");

            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.CSort).HasColumnName("c_sort");
        });

        modelBuilder.Entity<WmsShpOrder>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_shp_order_pkey");

            entity.ToTable("wms_shp_order");

            entity.HasIndex(e => e.COrderId, "uc_shp_order_id").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCdcTag)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_cdc_tag");
            entity.Property(e => e.CCountry)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_country");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCustomerGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_group");
            entity.Property(e => e.CCustomerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_name");
            entity.Property(e => e.CCustomerNo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_customer_no");
            entity.Property(e => e.CErpOrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_erp_order_id");
            entity.Property(e => e.CExternalConfirmed).HasColumnName("c_external_confirmed");
            entity.Property(e => e.CIsFixDeliveryDate).HasColumnName("c_is_fix_delivery_date");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CLocationGroup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group");
            entity.Property(e => e.CLocked).HasColumnName("c_locked");
            entity.Property(e => e.CMvmTransportorderPk).HasColumnName("c_mvm_transportorder_pk");
            entity.Property(e => e.CMyfactoryOrderNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_myfactory_order_number");
            entity.Property(e => e.CNextAllocation)
                .HasColumnType("datetime")
                .HasColumnName("c_next_allocation");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderSource)
                .HasMaxLength(255)
                .HasColumnName("c_order_source");
            entity.Property(e => e.COrderState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_state");
            entity.Property(e => e.COrderType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_orderType");
            entity.Property(e => e.CPickUpDate)
                .HasColumnType("datetime")
                .HasColumnName("c_pick_up_date");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CProcessType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("c_process_type");
            entity.Property(e => e.CShipper)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_shipper");
            entity.Property(e => e.CShippingDateFrom)
                .HasColumnType("datetime")
                .HasColumnName("c_shipping_date_from");
            entity.Property(e => e.CShippingDateTo)
                .HasColumnType("datetime")
                .HasColumnName("c_shipping_date_to");
            entity.Property(e => e.CShippingFailure).HasColumnName("c_shipping_failure");
            entity.Property(e => e.CStartDate)
                .HasColumnType("datetime")
                .HasColumnName("c_start_date");
            entity.Property(e => e.CStartMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_start_mode");
            entity.Property(e => e.CTitle)
                .HasMaxLength(255)
                .HasColumnName("c_title");
            entity.Property(e => e.CType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
            entity.Property(e => e.CWeight)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_weight");
        });

        modelBuilder.Entity<WmsShpOrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.COrderId, e.CKey }).HasName("wms_shp_order_detail_pkey");

            entity.ToTable("wms_shp_order_detail");

            entity.Property(e => e.COrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");
        });

        modelBuilder.Entity<WmsShpOrderId>(entity =>
        {
            entity.HasKey(e => e.CPk);

            entity.ToTable("wms_shp_order_id");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CCurrent)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("c_current");
            entity.Property(e => e.CName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPrefix)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_prefix");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsShpOrderPosition>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_shp_order_position_pkey");

            entity.ToTable("wms_shp_order_position");

            entity.HasIndex(e => new { e.COrderId, e.CPositionNo }, "uc_shp_order_id_pos").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAssignedUser)
                .HasMaxLength(255)
                .HasColumnName("c_assigned_user");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CErpPositionId).HasColumnName("c_erp_position_id");
            entity.Property(e => e.CLatestDue)
                .HasColumnType("datetime")
                .HasColumnName("c_latest_due");
            entity.Property(e => e.CLocked).HasColumnName("c_locked");
            entity.Property(e => e.CMvmTransportorderPosId).HasColumnName("c_mvm_transportorder_pos_id");
            entity.Property(e => e.CNextAllocation)
                .HasColumnType("datetime")
                .HasColumnName("c_next_allocation");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.COrderId)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.COrderState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_order_state");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CPositionNo).HasColumnName("c_position_no");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQtyAlloc).HasColumnName("c_qty_alloc");
            entity.Property(e => e.CQtyCrossdock)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty_crossdock");
            entity.Property(e => e.CQtyOrdered).HasColumnName("c_qty_ordered");
            entity.Property(e => e.CQtyShipped).HasColumnName("c_qty_shipped");
            entity.Property(e => e.CQtyTypeAlloc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_alloc");
            entity.Property(e => e.CQtyTypeCrossdock)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_crossdock");
            entity.Property(e => e.CQtyTypeOrdered)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_type_ordered");
            entity.Property(e => e.CSourceLocationGroups)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_source_location_groups");
            entity.Property(e => e.CStartEarliest)
                .HasColumnType("datetime")
                .HasColumnName("c_start_earliest");
            entity.Property(e => e.CTargetName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_name");
            entity.Property(e => e.CTargetType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_type");
            entity.Property(e => e.CToStartMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_to_start_mode");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.COrder).WithMany(p => p.WmsShpOrderPositions)
                .HasPrincipalKey(p => p.COrderId)
                .HasForeignKey(d => d.COrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_shp_order_id");
        });

        modelBuilder.Entity<WmsShpOrderPositionDetail>(entity =>
        {
            entity.HasKey(e => new { e.COrderId, e.CPositionNo, e.CKey }).HasName("wms_shp_order_position_detail_pkey");

            entity.ToTable("wms_shp_order_position_detail");

            entity.Property(e => e.COrderId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_order_id");
            entity.Property(e => e.CPositionNo).HasColumnName("c_position_no");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");
        });

        modelBuilder.Entity<WmsShpOrderPositionSplit>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_shp_order_position_split_pkey");

            entity.ToTable("wms_shp_order_position_split");

            entity.HasIndex(e => new { e.CPositionPk, e.CSplitNo }, "uc_shp_pos_split").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CLoadUnitPkey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_load_unit_pkey");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPositionPk).HasColumnName("c_position_pk");
            entity.Property(e => e.CPriority).HasColumnName("c_priority");
            entity.Property(e => e.CProblemMessage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_problem_message");
            entity.Property(e => e.CProblemMessageNo).HasColumnName("c_problem_message_no");
            entity.Property(e => e.CProblemOccurred)
                .HasColumnType("datetime")
                .HasColumnName("c_problem_occurred");
            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CQty)
                .IsRequired()
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("c_qty");
            entity.Property(e => e.CQuantityType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_quantity_type");
            entity.Property(e => e.CReservationId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_reservation_id");
            entity.Property(e => e.CSplitNo).HasColumnName("c_split_no");
            entity.Property(e => e.CStartMode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_start_mode");
            entity.Property(e => e.CTargetName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_name");
            entity.Property(e => e.CTargetType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_target_type");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CPositionPkNavigation).WithMany(p => p.WmsShpOrderPositionSplits)
                .HasForeignKey(d => d.CPositionPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_position_pk");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsShpOrderPositionSplits)
                .HasForeignKey(d => d.CProductPk)
                .HasConstraintName("fk_shp_pos_split_product");
        });

        modelBuilder.Entity<WmsShpProduct>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_shp_product_pkey");

            entity.ToTable("wms_shp_product");

            entity.HasIndex(e => e.CForeignPid, "uc_shp_product_foreign_pid").IsUnique();

            entity.HasIndex(e => e.CSku, "uc_shp_product_sku").IsUnique();

            entity.HasIndex(e => e.CSku, "uk_gn6uwok9kkax8h1kcxt6unju0").IsUnique();

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CForeignPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pid");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CSku)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CStockZone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_stock_zone");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsShpProductDetail>(entity =>
        {
            entity.HasKey(e => new { e.CProductPk, e.CKey }).HasName("wms_shp_product_detail_pkey");

            entity.ToTable("wms_shp_product_detail");

            entity.Property(e => e.CProductPk).HasColumnName("c_product_pk");
            entity.Property(e => e.CKey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_key");
            entity.Property(e => e.CValue)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_value");

            entity.HasOne(d => d.CProductPkNavigation).WithMany(p => p.WmsShpProductDetails)
                .HasForeignKey(d => d.CProductPk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_shp_details_product");
        });

        modelBuilder.Entity<WmsTaskGroup>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_task_group_pkey");

            entity.ToTable("wms_task_group");

            entity.Property(e => e.CPk)
                .ValueGeneratedNever()
                .HasColumnName("c_pk");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_name");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");
        });

        modelBuilder.Entity<WmsTaskReconciliation>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_task_reconciliation_pkey");

            entity.ToTable("wms_task_reconciliation");

            entity.HasIndex(e => e.CTaskId, "uc_task_id").IsUnique();

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CAssignedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_assigned_at");
            entity.Property(e => e.CAssignedTo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_assigned_to");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CDirectBookingAllowed).HasColumnName("c_direct_booking_allowed");
            entity.Property(e => e.CErpCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_erp_code");
            entity.Property(e => e.CFinishedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_finished_at");
            entity.Property(e => e.CFromTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_from_transport_unit_bk");
            entity.Property(e => e.CLocationGroupName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_location_group_name");
            entity.Property(e => e.CMixedProducts).HasColumnName("c_mixed_products");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CParentTask).HasColumnName("c_parent_task");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CStartedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_started_at");
            entity.Property(e => e.CState)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_state");
            entity.Property(e => e.CTaskGroup).HasColumnName("c_task_group");
            entity.Property(e => e.CTaskId)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_task_id");
            entity.Property(e => e.CType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_type");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CParentTaskNavigation).WithMany(p => p.InverseCParentTaskNavigation)
                .HasForeignKey(d => d.CParentTask)
                .HasConstraintName("fk_tsk_tsk_parent");

            entity.HasOne(d => d.CTaskGroupNavigation).WithMany(p => p.WmsTaskReconciliations)
                .HasForeignKey(d => d.CTaskGroup)
                .HasConstraintName("fk_tsk_grp");
        });

        modelBuilder.Entity<WmsTaskReconciliationReport>(entity =>
        {
            entity.HasKey(e => e.CPk).HasName("wms_task_reconciliation_report_pkey");

            entity.ToTable("wms_task_reconciliation_report");

            entity.Property(e => e.CPk).HasColumnName("c_pk");
            entity.Property(e => e.CCountType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_count_type");
            entity.Property(e => e.CCountedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_counted_at");
            entity.Property(e => e.CCountedBy)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_counted_by");
            entity.Property(e => e.CCreated)
                .HasColumnType("datetime")
                .HasColumnName("c_created");
            entity.Property(e => e.CDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_description");
            entity.Property(e => e.CForeignPkey)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_foreign_pkey");
            entity.Property(e => e.CLabel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_label");
            entity.Property(e => e.CMessage)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("c_message");
            entity.Property(e => e.COl).HasColumnName("c_ol");
            entity.Property(e => e.CPid)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_pid");
            entity.Property(e => e.CProcessedAt)
                .HasColumnType("datetime")
                .HasColumnName("c_processed_at");
            entity.Property(e => e.CQtyCounted).HasColumnName("c_qty_counted");
            entity.Property(e => e.CQtyCountedType)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_qty_counted_type");
            entity.Property(e => e.CQtyExpected).HasColumnName("c_qty_expected");
            entity.Property(e => e.CReconciliationReason)
                .HasMaxLength(50)
                .HasColumnName("c_reconciliation_reason");
            entity.Property(e => e.CSku)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_sku");
            entity.Property(e => e.CTask).HasColumnName("c_task");
            entity.Property(e => e.CTransportUnitBk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("c_transport_unit_bk");
            entity.Property(e => e.CUpdated)
                .HasColumnType("datetime")
                .HasColumnName("c_updated");

            entity.HasOne(d => d.CTaskNavigation).WithMany(p => p.WmsTaskReconciliationReports)
                .HasForeignKey(d => d.CTask)
                .HasConstraintName("fk_tsk_rep_tsk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
