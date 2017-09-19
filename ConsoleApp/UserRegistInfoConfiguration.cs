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

    // UserRegistInfo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class UserRegistInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserRegistInfo>
    {
        public UserRegistInfoConfiguration()
            : this("dbo")
        {
        }

        public UserRegistInfoConfiguration(string schema)
        {
            ToTable("UserRegistInfo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.SalesOutletUniqueId).HasColumnName(@"SalesOutletUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.StoreUniqueId).HasColumnName(@"StoreUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.RegistMethod).HasColumnName(@"RegistMethod").HasColumnType("int").IsOptional();
            Property(x => x.UserUniqueId).HasColumnName(@"UserUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.Username).HasColumnName(@"Username").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RegisteTime).HasColumnName(@"RegisteTime").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>