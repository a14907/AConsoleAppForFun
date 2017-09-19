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

    // SyncSalesOutletGPSInfo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncSalesOutletGpsInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncSalesOutletGpsInfo>
    {
        public SyncSalesOutletGpsInfoConfiguration()
            : this("dbo")
        {
        }

        public SyncSalesOutletGpsInfoConfiguration(string schema)
        {
            ToTable("SyncSalesOutletGPSInfo", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SalesOutletType).HasColumnName(@"SalesOutletType").HasColumnType("int").IsOptional();
            Property(x => x.SalesOutletUniqueId).HasColumnName(@"SalesOutletUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.Longitude).HasColumnName(@"Longitude").HasColumnType("float").IsOptional();
            Property(x => x.Latitude).HasColumnName(@"Latitude").HasColumnType("float").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.IsRecommend).HasColumnName(@"IsRecommend").HasColumnType("bit").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.TempSalesOutletId).HasColumnName(@"TempSalesOutletID").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
