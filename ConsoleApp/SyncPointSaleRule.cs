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

    // SyncPointSaleRules
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncPointSaleRule
    {
        public long Id { get; set; } // ID (Primary key)
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)
        public string Code { get; set; } // Code (length: 50)
        public System.Guid? PointCommissionSaleUniqueId { get; set; } // PointCommissionSaleUniqueID
        public string Title { get; set; } // Title (length: 100)
        public int? Type { get; set; } // Type
        public decimal? GiveAmount { get; set; } // GiveAmount
        public decimal? PointAmount { get; set; } // PointAmount
        public decimal? Price { get; set; } // Price
        public decimal? SaleMaxLimit { get; set; } // SaleMaxLimit
        public decimal? SaleAmount { get; set; } // SaleAmount
        public int? PriReturnStageNumber { get; set; } // PriReturnStageNumber
        public int? GiveReturnStageNumber { get; set; } // GiveReturnStageNumber
        public int? StageLength { get; set; } // StageLength
        public string Remark { get; set; } // Remark (length: 350)
        public int? Status { get; set; } // Status
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime
        public int? TempPointCommissionSaleId { get; set; } // TempPointCommissionSaleID

        public SyncPointSaleRule()
        {
            UniqueId = System.Guid.NewGuid();
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>
