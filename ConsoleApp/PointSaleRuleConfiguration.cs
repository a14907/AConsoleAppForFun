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

    // PointSaleRules
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class PointSaleRuleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PointSaleRule>
    {
        public PointSaleRuleConfiguration()
            : this("dbo")
        {
        }

        public PointSaleRuleConfiguration(string schema)
        {
            ToTable("PointSaleRules", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PointCommissionSaleUniqueId).HasColumnName(@"PointCommissionSaleUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsOptional();
            Property(x => x.GiveAmount).HasColumnName(@"GiveAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.PointAmount).HasColumnName(@"PointAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.SaleMaxLimit).HasColumnName(@"SaleMaxLimit").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.SaleAmount).HasColumnName(@"SaleAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.PriReturnStageNumber).HasColumnName(@"PriReturnStageNumber").HasColumnType("int").IsOptional();
            Property(x => x.GiveReturnStageNumber).HasColumnName(@"GiveReturnStageNumber").HasColumnType("int").IsOptional();
            Property(x => x.StageLength).HasColumnName(@"StageLength").HasColumnType("int").IsOptional();
            Property(x => x.Remark).HasColumnName(@"Remark").HasColumnType("nvarchar").IsOptional().HasMaxLength(350);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>