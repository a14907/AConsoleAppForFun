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
    public class ServiceCode
    {
        public int Id { get; set; } // ID
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)

        ///<summary>
        /// 商家ID
        ///</summary>
        public System.Guid? MerchantUniqueId { get; set; } // MerchantUniqueID

        ///<summary>
        /// 商家盖网号
        ///</summary>
        public string MerchantCode { get; set; } // MerchantCode (length: 50)

        ///<summary>
        /// 商家管理者ID
        ///</summary>
        public System.Guid? OwnerUniqueId { get; set; } // OwnerUniqueID

        ///<summary>
        /// 商家管理者盖网号
        ///</summary>
        public string OwnerCode { get; set; } // OwnerCode (length: 50)

        ///<summary>
        /// 营运中心ID
        ///</summary>
        public System.Guid? OperationCenterUniqueId { get; set; } // OperationCenterUniqueID

        ///<summary>
        /// 运营商盖网号
        ///</summary>
        public string OperationCenterCode { get; set; } // OperationCenterCode (length: 50)

        ///<summary>
        /// 绑定的销售网点唯一标识
        ///</summary>
        public System.Guid? SalesOutletUniqueId { get; set; } // SalesOutletUniqueID

        ///<summary>
        /// 绑定的销售网点类型（0:门店；1：售货机；2：盖鲜生）
        ///</summary>
        public int? SalesOutletType { get; set; } // SalesOutletType

        ///<summary>
        /// 是否已经绑定
        ///</summary>
        public bool? IsBind { get; set; } // IsBind
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        ///<summary>
        /// 0.未确认   1.码主确认绑定营运中心  2.码主确认绑定商家 3、冻结
        ///</summary>
        public int? ApproveStatus { get; set; } // ApproveStatus

        ///<summary>
        /// 类型：0 默认值，1 瓦格手机  2、其它
        ///</summary>
        public int? Type { get; set; } // Type

        ///<summary>
        /// 商家名称
        ///</summary>
        public string MerchantName { get; set; } // MerchantName (length: 50)
        public string Code { get; set; } // Code (length: 50)

        ///<summary>
        /// 是否是前30万个出售的服务码
        ///</summary>
        public bool? IsFirstBatchCode { get; set; } // IsFirstBatchCode

        ///<summary>
        /// 服务码出售时间
        ///</summary>
        public System.DateTime? SalesTime { get; set; } // SalesTime
        public string SalesOrderCode { get; set; } // SalesOrderCode (length: 50)

        ///<summary>
        /// 关联唯一ID，用于存储服务码的关联数据
        ///</summary>
        public System.Guid? RelevanceUniqueId { get; set; } // RelevanceUniqueID

        ///<summary>
        /// 销售渠道（1、商城 10、其它）
        ///</summary>
        public int? SalesSource { get; set; } // SalesSource

        ///<summary>
        /// 是否营运中心的基础绑定码
        ///</summary>
        public bool? IsOperationCenterBasicCode { get; set; } // IsOperationCenterBasicCode

        public ServiceCode()
        {
            IsBind = false;
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
            Type = 0;
        }
    }

}
// </auto-generated>