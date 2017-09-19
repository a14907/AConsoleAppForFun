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

    // BASE_AdminUser
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class BaseAdminUser
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
        /// 用户名称
        ///</summary>
        public string UserName { get; set; } // UserName (length: 50)

        ///<summary>
        /// 密码
        ///</summary>
        public string Password { get; set; } // Password (length: 500)

        ///<summary>
        /// 密码盐
        ///</summary>
        public string Salt { get; set; } // Salt (length: 500)

        ///<summary>
        /// 账户状态
        ///</summary>
        public int Status { get; set; } // Status

        ///<summary>
        /// 是否锁定
        ///</summary>
        public bool Locked { get; set; } // Locked

        ///<summary>
        /// 最后登录时间
        ///</summary>
        public System.DateTime? LastLoginDate { get; set; } // LastLoginDate

        ///<summary>
        /// 预留字段1
        ///</summary>
        public string Remark1 { get; set; } // Remark1 (length: 50)

        ///<summary>
        /// 预留字段2
        ///</summary>
        public string Remark2 { get; set; } // Remark2 (length: 50)

        ///<summary>
        /// 预留字段3
        ///</summary>
        public string Remark3 { get; set; } // Remark3 (length: 50)

        ///<summary>
        /// 预留字段4
        ///</summary>
        public string Remark4 { get; set; } // Remark4 (length: 50)

        ///<summary>
        /// 预留字段5
        ///</summary>
        public string Remark5 { get; set; } // Remark5 (length: 50)

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

        public BaseAdminUser()
        {
            IsDisabled = false;
        }
    }

}
// </auto-generated>