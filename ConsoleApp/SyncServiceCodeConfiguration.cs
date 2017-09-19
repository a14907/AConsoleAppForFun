// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ConsoleApp
{

    // SyncServiceCode
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncServiceCodeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncServiceCode>
    {
        public SyncServiceCodeConfiguration()
            : this("dbo")
        {
        }

        public SyncServiceCodeConfiguration(string schema)
        {
            ToTable("SyncServiceCode", schema);
            HasKey(x => new { x.Id, x.UniqueId });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MerchantUniqueId).HasColumnName(@"MerchantUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.MerchantCode).HasColumnName(@"MerchantCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.OwnerUniqueId).HasColumnName(@"OwnerUniqueID").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.OwnerCode).HasColumnName(@"OwnerCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.OperationCenterUniqueId).HasColumnName(@"OperationCenterUniqueID").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.OperationCenterCode).HasColumnName(@"OperationCenterCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SalesOutletUniqueId).HasColumnName(@"SalesOutletUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.SalesOutletType).HasColumnName(@"SalesOutletType").HasColumnType("int").IsOptional();
            Property(x => x.IsBind).HasColumnName(@"IsBind").HasColumnType("bit").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.ApproveStatus).HasColumnName(@"ApproveStatus").HasColumnType("int").IsOptional();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsOptional();
            Property(x => x.MerchantName).HasColumnName(@"MerchantName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.OrderCode).HasColumnName(@"OrderCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

}
// </auto-generated>
