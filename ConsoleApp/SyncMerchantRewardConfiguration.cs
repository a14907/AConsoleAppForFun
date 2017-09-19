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

    // SyncMerchantReward
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncMerchantRewardConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SyncMerchantReward>
    {
        public SyncMerchantRewardConfiguration()
            : this("dbo")
        {
        }

        public SyncMerchantRewardConfiguration(string schema)
        {
            ToTable("SyncMerchantReward", schema);
            HasKey(x => new { x.UniqueId, x.Id });

            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.MerchantUniqueId).HasColumnName(@"MerchantUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.MerchantName).HasColumnName(@"MerchantName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.MerchantCode).HasColumnName(@"MerchantCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Mobile).HasColumnName(@"Mobile").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.OperatorUniqueId).HasColumnName(@"OperatorUniqueID").HasColumnType("uniqueidentifier").IsOptional();
            Property(x => x.OperatorName).HasColumnName(@"OperatorName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.PassedStageNumber).HasColumnName(@"PassedStageNumber").HasColumnType("int").IsOptional();
            Property(x => x.TotalStageNumber).HasColumnName(@"TotalStageNumber").HasColumnType("int").IsOptional();
            Property(x => x.StageInterval).HasColumnName(@"StageInterval").HasColumnType("int").IsOptional();
            Property(x => x.TotalRewardAmount).HasColumnName(@"TotalRewardAmount").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.RewardPerStage).HasColumnName(@"RewardPerStage").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.TempOperatorId).HasColumnName(@"TempOperatorID").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>