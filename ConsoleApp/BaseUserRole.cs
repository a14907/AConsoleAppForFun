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

    // BASE_UserRole
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class BaseUserRole
    {

        ///<summary>
        /// 自增ID
        ///</summary>
        public long Id { get; set; } // Id (Primary key)

        ///<summary>
        /// 系统ID
        ///</summary>
        public string SystemId { get; set; } // SystemId (length: 50)

        ///<summary>
        /// 用户ID
        ///</summary>
        public string UserId { get; set; } // UserId (length: 50)

        ///<summary>
        /// 角色ID
        ///</summary>
        public string RoleId { get; set; } // RoleId (length: 50)

        ///<summary>
        /// 是否可授权
        ///</summary>
        public bool CanGrant { get; set; } // CanGrant

        ///<summary>
        /// 失效日期
        ///</summary>
        public System.DateTime? InvalidDate { get; set; } // InvalidDate

        ///<summary>
        /// 添加者
        ///</summary>
        public string CreateBy { get; set; } // CreateBy (length: 50)

        ///<summary>
        /// 添加时间
        ///</summary>
        public System.DateTime? CreateDate { get; set; } // CreateDate

        ///<summary>
        /// 更新者
        ///</summary>
        public string UpdateBy { get; set; } // UpdateBy (length: 50)

        ///<summary>
        /// 更新时间
        ///</summary>
        public System.DateTime? UpdateDate { get; set; } // UpdateDate

        ///<summary>
        /// 是否失效
        ///</summary>
        public bool IsDisabled { get; set; } // IsDisabled

        public BaseUserRole()
        {
            IsDisabled = false;
        }
    }

}
// </auto-generated>
