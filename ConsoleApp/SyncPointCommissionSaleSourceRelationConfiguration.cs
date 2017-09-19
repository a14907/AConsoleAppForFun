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

    // SyncPointCommissionSaleSourceRelation
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncPointCommissionSaleSourceRelationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncPointCommissionSaleSourceRelation>
    {
        public SyncPointCommissionSaleSourceRelationConfiguration()
            : this("dbo")
        {
        }

        public SyncPointCommissionSaleSourceRelationConfiguration(string schema)
        {
            ToTable("SyncPointCommissionSaleSourceRelation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.PointCommissionSaleSourceUniqueId).HasColumnName(@"PointCommissionSaleSourceUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.PointCommissionSaleUniqueId).HasColumnName(@"PointCommissionSaleUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.CommissionAmount).HasColumnName(@"CommissionAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.CommissionType).HasColumnName(@"CommissionType").HasColumnType("int").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.TempPointCommissionSaleSourceId).HasColumnName(@"TempPointCommissionSaleSourceID").HasColumnType("int").IsOptional();
            Property(x => x.TempPointCommissionSaleId).HasColumnName(@"TempPointCommissionSaleID").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
