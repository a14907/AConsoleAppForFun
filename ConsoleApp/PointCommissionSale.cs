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

    // PointCommissionSale
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class PointCommissionSale
    {
        public int Id { get; set; } // ID
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)

        ///<summary>
        /// 挂单编码
        ///</summary>
        public string Code { get; set; } // Code (length: 50)

        ///<summary>
        /// 绑定金额
        ///</summary>
        public decimal? BindAmount { get; set; } // BindAmount

        ///<summary>
        /// 非绑定金额
        ///</summary>
        public decimal? UnBindAmount { get; set; } // UnBindAmount

        ///<summary>
        /// 挂单类型：1：待绑定积分（可以提供用户收益绑定）2：非绑定积分（不提供用户收益绑定）
        ///</summary>
        public decimal? LeftAmount { get; set; } // LeftAmount

        ///<summary>
        /// 绑定粒度
        ///</summary>
        public decimal? BindSize { get; set; } // BindSize

        ///<summary>
        /// 挂单开始时间
        ///</summary>
        public System.DateTime? StartTime { get; set; } // StartTime

        ///<summary>
        /// 挂单结束时间
        ///</summary>
        public System.DateTime? EndTime { get; set; } // EndTime

        ///<summary>
        /// 状态：0：待启用；1：启用；2：终止
        ///</summary>
        public int? Status { get; set; } // Status
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        ///<summary>
        /// 出售金额
        ///</summary>
        public decimal? SoldAmount { get; set; } // SoldAmount

        public PointCommissionSale()
        {
            CreateTime = System.DateTime.UtcNow;
            UpdateTime = System.DateTime.UtcNow;
        }
    }

}
// </auto-generated>
