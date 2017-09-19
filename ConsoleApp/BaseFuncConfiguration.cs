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

    // BASE_Func
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class BaseFuncConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BaseFunc>
    {
        public BaseFuncConfiguration()
            : this("dbo")
        {
        }

        public BaseFuncConfiguration(string schema)
        {
            ToTable("BASE_Func", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SystemId).HasColumnName(@"SystemId").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.FuncId).HasColumnName(@"FuncId").HasColumnType("nvarchar").IsRequired().HasMaxLength(50);
            Property(x => x.FuncName).HasColumnName(@"FuncName").HasColumnType("nvarchar").IsRequired().HasMaxLength(4000);
            Property(x => x.FuncType).HasColumnName(@"FuncType").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Remark).HasColumnName(@"Remark").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.CreateBy).HasColumnName(@"CreateBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("datetime2").IsOptional();
            Property(x => x.IsDisabled).HasColumnName(@"IsDisabled").HasColumnType("bit").IsRequired();
            Property(x => x.ParentId).HasColumnName(@"ParentId").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.FuncPath).HasColumnName(@"FuncPath").HasColumnType("nvarchar").IsOptional().HasMaxLength(300);
        }
    }

}
// </auto-generated>
