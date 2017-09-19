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

    // SyncGXSPosDealInfo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncGxsPosDealInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncGxsPosDealInfo>
    {
        public SyncGxsPosDealInfoConfiguration()
            : this("dbo")
        {
        }

        public SyncGxsPosDealInfoConfiguration(string schema)
        {
            ToTable("SyncGXSPosDealInfo", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired();
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.UserUniqueId).HasColumnName(@"UserUniqueID").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.Phone).HasColumnName(@"Phone").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(32);
            Property(x => x.CardNo).HasColumnName(@"CardNO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Amount).HasColumnName(@"Amount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.SerialNo).HasColumnName(@"SerialNO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.TransactionTime).HasColumnName(@"TransactionTime").HasColumnType("datetime").IsOptional();
            Property(x => x.BusinessNo).HasColumnName(@"BusinessNO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.DeviceNo).HasColumnName(@"DeviceNO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.MerchantName).HasColumnName(@"MerchantName").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.OperatorUniqueId).HasColumnName(@"OperatorUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.PaymentRreceiptNo).HasColumnName(@"PaymentRreceiptNO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BatchNo).HasColumnName(@"BatchNO").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CardValidDate).HasColumnName(@"CardValidDate").HasColumnType("datetime").IsOptional();
            Property(x => x.TransactionType).HasColumnName(@"TransactionType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(17);
            Property(x => x.BankOfCard).HasColumnName(@"BankOfCard").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.BankOfReceive).HasColumnName(@"BankOfReceive").HasColumnType("nvarchar").IsOptional().HasMaxLength(100);
            Property(x => x.AccountClearDate).HasColumnName(@"AccountClearDate").HasColumnType("datetime").IsOptional();
            Property(x => x.SalesOrderId).HasColumnName(@"SalesOrderID").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.TempSalesOrderId).HasColumnName(@"TempSalesOrderID").HasColumnType("int").IsOptional();
            Property(x => x.TempOperatorId).HasColumnName(@"TempOperatorID").HasColumnType("int").IsOptional();
            Property(x => x.TempUserCode).HasColumnName(@"TempUserCode").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
        }
    }

}
// </auto-generated>
