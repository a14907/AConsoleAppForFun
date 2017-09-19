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

    // SyncAdvertisePosition
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncAdvertisePositionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncAdvertisePosition>
    {
        public SyncAdvertisePositionConfiguration()
            : this("dbo")
        {
        }

        public SyncAdvertisePositionConfiguration(string schema)
        {
            ToTable("SyncAdvertisePosition", schema);
            HasKey(x => new { x.Id, x.UniqueId });

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AppId).HasColumnName(@"AppID").HasColumnType("int").IsOptional();
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Content).HasColumnName(@"Content").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.Width).HasColumnName(@"Width").HasColumnType("int").IsOptional();
            Property(x => x.Height).HasColumnName(@"Height").HasColumnType("int").IsOptional();
            Property(x => x.Clicks).HasColumnName(@"Clicks").HasColumnType("int").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
