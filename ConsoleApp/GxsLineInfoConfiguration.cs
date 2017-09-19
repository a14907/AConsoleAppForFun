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

    // GXSLineInfo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class GxsLineInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<GxsLineInfo>
    {
        public GxsLineInfoConfiguration()
            : this("dbo")
        {
        }

        public GxsLineInfoConfiguration(string schema)
        {
            ToTable("GXSLineInfo", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.RenterUniqueId).HasColumnName(@"RenterUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.MachineUniqueId).HasColumnName(@"MachineUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.ExpireTime).HasColumnName(@"ExpireTime").HasColumnType("datetime").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.MerchantCode).HasColumnName(@"MerchantCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
