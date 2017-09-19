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

    // ServiceCodeImportRecord
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ServiceCodeImportRecordConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ServiceCodeImportRecord>
    {
        public ServiceCodeImportRecordConfiguration()
            : this("dbo")
        {
        }

        public ServiceCodeImportRecordConfiguration(string schema)
        {
            ToTable("ServiceCodeImportRecord", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SalesOrderCode).HasColumnName(@"SalesOrderCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SalesOrderActiveTime).HasColumnName(@"SalesOrderActiveTime").HasColumnType("datetime").IsOptional();
            Property(x => x.SalesOrderAmount).HasColumnName(@"SalesOrderAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.OwnerCode).HasColumnName(@"OwnerCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.OwnerMobile).HasColumnName(@"OwnerMobile").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SalesItemQuantity).HasColumnName(@"SalesItemQuantity").HasColumnType("int").IsOptional();
            Property(x => x.SaleItemName).HasColumnName(@"SaleItemName").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.ServiceCodeAmount).HasColumnName(@"ServiceCodeAmount").HasColumnType("int").IsOptional();
            Property(x => x.CodeType).HasColumnName(@"CodeType").HasColumnType("int").IsOptional();
            Property(x => x.ImportUserUinqueId).HasColumnName(@"ImportUserUinqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.IsSuccess).HasColumnName(@"IsSuccess").HasColumnType("bit").IsOptional();
            Property(x => x.Note).HasColumnName(@"Note").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
