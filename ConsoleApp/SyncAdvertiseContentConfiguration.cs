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

    // SyncAdvertiseContent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncAdvertiseContentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncAdvertiseContent>
    {
        public SyncAdvertiseContentConfiguration()
            : this("dbo")
        {
        }

        public SyncAdvertiseContentConfiguration(string schema)
        {
            ToTable("SyncAdvertiseContent", schema);
            HasKey(x => new { x.Id, x.UniqueId });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.PositionUniqueId).HasColumnName(@"PositionUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.StartTime).HasColumnName(@"StartTime").HasColumnType("datetime").IsOptional();
            Property(x => x.EndTime).HasColumnName(@"EndTime").HasColumnType("datetime").IsOptional();
            Property(x => x.Content).HasColumnName(@"Content").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Sort).HasColumnName(@"Sort").HasColumnType("int").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.Province).HasColumnName(@"Province").HasColumnType("int").IsOptional();
            Property(x => x.City).HasColumnName(@"City").HasColumnType("int").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.TempAdvertiseId).HasColumnName(@"TempAdvertiseID").HasColumnType("int").IsOptional();
            Property(x => x.CountryName).HasColumnName(@"CountryName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.ProvinceName).HasColumnName(@"ProvinceName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CityName).HasColumnName(@"CityName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

}
// </auto-generated>
