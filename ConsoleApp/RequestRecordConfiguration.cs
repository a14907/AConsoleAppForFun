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

    // RequestRecord
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class RequestRecordConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RequestRecord>
    {
        public RequestRecordConfiguration()
            : this("dbo")
        {
        }

        public RequestRecordConfiguration(string schema)
        {
            ToTable("RequestRecord", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Signature).HasColumnName(@"Signature").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.InterfaceUrl).HasColumnName(@"InterfaceURL").HasColumnType("nvarchar").IsOptional().HasMaxLength(200);
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
