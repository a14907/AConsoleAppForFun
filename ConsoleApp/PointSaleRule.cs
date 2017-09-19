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

    // PointSaleRules
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class PointSaleRule
    {

        ///<summary>
        /// ID,自增长
        ///</summary>
        public long Id { get; set; } // ID

        ///<summary>
        /// 唯一主键ID
        ///</summary>
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)

        ///<summary>
        /// 编码
        ///</summary>
        public string Code { get; set; } // Code (length: 50)

        ///<summary>
        /// 挂单ID
        ///</summary>
        public System.Guid? PointCommissionSaleUniqueId { get; set; } // PointCommissionSaleUniqueID

        ///<summary>
        /// 标题
        ///</summary>
        public string Title { get; set; } // Title (length: 100)

        ///<summary>
        /// 类型：1：新用户；2：老用户
        ///</summary>
        public int? Type { get; set; } // Type

        ///<summary>
        /// 赠送金额
        ///</summary>
        public decimal? GiveAmount { get; set; } // GiveAmount

        ///<summary>
        /// 积分面值
        ///</summary>
        public decimal? PointAmount { get; set; } // PointAmount

        ///<summary>
        /// 售价
        ///</summary>
        public decimal? Price { get; set; } // Price

        ///<summary>
        /// 积分包限额，这种类型规则的积分能卖多少份
        ///</summary>
        public decimal? SaleMaxLimit { get; set; } // SaleMaxLimit

        ///<summary>
        /// 已销售总额
        ///</summary>
        public decimal? SaleAmount { get; set; } // SaleAmount

        ///<summary>
        /// 本金返回分期，分多少期返给用户
        ///</summary>
        public int? PriReturnStageNumber { get; set; } // PriReturnStageNumber

        ///<summary>
        /// 赠送金额返回分期
        ///</summary>
        public int? GiveReturnStageNumber { get; set; } // GiveReturnStageNumber

        ///<summary>
        /// 分期时长（天）
        ///</summary>
        public int? StageLength { get; set; } // StageLength

        ///<summary>
        /// 备注
        ///</summary>
        public string Remark { get; set; } // Remark (length: 350)

        ///<summary>
        /// 状态：0：待启用；1：启用；2：已生成产品；3：终止
        ///</summary>
        public int? Status { get; set; } // Status

        ///<summary>
        /// 创建时间
        ///</summary>
        public System.DateTime? CreateTime { get; set; } // CreateTime

        ///<summary>
        /// 更新时间
        ///</summary>
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        public PointSaleRule()
        {
            Type = 1;
            PriReturnStageNumber = 1;
            GiveReturnStageNumber = 1;
            StageLength = 30;
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>