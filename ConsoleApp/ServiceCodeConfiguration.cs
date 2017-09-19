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

    // ServiceCode
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ServiceCodeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ServiceCode>
    {
        public ServiceCodeConfiguration()
            : this("dbo")
        {
        }

        public ServiceCodeConfiguration(string schema)
        {
            ToTable("ServiceCode", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MerchantUniqueId).HasColumnName(@"MerchantUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.MerchantCode).HasColumnName(@"MerchantCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.OwnerUniqueId).HasColumnName(@"OwnerUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.OwnerCode).HasColumnName(@"OwnerCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.OperationCenterUniqueId).HasColumnName(@"OperationCenterUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.OperationCenterCode).HasColumnName(@"OperationCenterCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SalesOutletUniqueId).HasColumnName(@"SalesOutletUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.SalesOutletType).HasColumnName(@"SalesOutletType").HasColumnType("int").IsOptional();
            Property(x => x.IsBind).HasColumnName(@"IsBind").HasColumnType("bit").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.ApproveStatus).HasColumnName(@"ApproveStatus").HasColumnType("int").IsOptional();
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("int").IsOptional();
            Property(x => x.MerchantName).HasColumnName(@"MerchantName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IsFirstBatchCode).HasColumnName(@"IsFirstBatchCode").HasColumnType("bit").IsOptional();
            Property(x => x.SalesTime).HasColumnName(@"SalesTime").HasColumnType("datetime").IsOptional();
            Property(x => x.SalesOrderCode).HasColumnName(@"SalesOrderCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RelevanceUniqueId).HasColumnName(@"RelevanceUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.SalesSource).HasColumnName(@"SalesSource").HasColumnType("int").IsOptional();
            Property(x => x.IsOperationCenterBasicCode).HasColumnName(@"IsOperationCenterBasicCode").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>