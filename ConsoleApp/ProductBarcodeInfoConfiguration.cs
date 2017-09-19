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

    // ProductBarcodeInfo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class ProductBarcodeInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProductBarcodeInfo>
    {
        public ProductBarcodeInfoConfiguration()
            : this("dbo")
        {
        }

        public ProductBarcodeInfoConfiguration(string schema)
        {
            ToTable("ProductBarcodeInfo", schema);
            HasKey(x => x.UniqueId);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UniqueId).HasColumnName(@"UniqueID").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Barcode).HasColumnName(@"Barcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(16);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.Brand).HasColumnName(@"Brand").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(64);
            Property(x => x.CategoryId).HasColumnName(@"CategoryID").HasColumnType("bigint").IsOptional();
            Property(x => x.CategoryName).HasColumnName(@"CategoryName").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.DefaultPrice).HasColumnName(@"DefaultPrice").HasColumnType("decimal").IsOptional().HasPrecision(18,5);
            Property(x => x.Thumbnail).HasColumnName(@"Thumbnail").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Specification).HasColumnName(@"Specification").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(128);
            Property(x => x.Unit).HasColumnName(@"Unit").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.SubmitByMerchant).HasColumnName(@"SubmitByMerchant").HasColumnType("int").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsOptional();
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreatorUserCode).HasColumnName(@"CreatorUserCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.CreatorId).HasColumnName(@"CreatorID").HasColumnType("int").IsOptional();
            Property(x => x.ProductPictures).HasColumnName(@"ProductPictures").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").HasColumnType("datetime").IsOptional();
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
