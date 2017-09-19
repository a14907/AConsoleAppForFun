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

    // AdvertiseContent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class AdvertiseContent
    {
        public int Id { get; set; } // ID
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)
        public string Code { get; set; } // Code (length: 50)

        ///<summary>
        /// 广告位ID
        ///</summary>
        public System.Guid? PositionUniqueId { get; set; } // PositionUniqueID

        ///<summary>
        /// 广告标题
        ///</summary>
        public string Title { get; set; } // Title (length: 128)

        ///<summary>
        /// 开始时间
        ///</summary>
        public System.DateTime? StartTime { get; set; } // StartTime

        ///<summary>
        /// 结束时间
        ///</summary>
        public System.DateTime? EndTime { get; set; } // EndTime

        ///<summary>
        /// 内容
        ///</summary>
        public string Content { get; set; } // Content

        ///<summary>
        /// 排序
        ///</summary>
        public int? Sort { get; set; } // Sort

        ///<summary>
        /// 状态
        ///</summary>
        public int? Status { get; set; } // Status

        ///<summary>
        /// 国家
        ///</summary>
        public int? Country { get; set; } // Country
        public string CountryName { get; set; } // CountryName (length: 50)

        ///<summary>
        /// 省
        ///</summary>
        public int? Province { get; set; } // Province
        public string ProvinceName { get; set; } // ProvinceName (length: 50)

        ///<summary>
        /// 市
        ///</summary>
        public int? City { get; set; } // City
        public string CityName { get; set; } // CityName (length: 50)
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        public AdvertiseContent()
        {
            CreateTime = System.DateTime.UtcNow;
            UpdateTime = System.DateTime.UtcNow;
        }
    }

}
// </auto-generated>