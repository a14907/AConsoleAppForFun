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

    // MerchantApplication
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class MerchantApplication
    {

        ///<summary>
        /// 唯一主键ID
        ///</summary>
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)

        ///<summary>
        /// ID,自增长
        ///</summary>
        public long Id { get; set; } // ID

        ///<summary>
        /// 编码
        ///</summary>
        public string Code { get; set; } // Code (length: 50)

        ///<summary>
        /// 申请人姓名
        ///</summary>
        public string Name { get; set; } // Name (length: 20)

        ///<summary>
        /// 商家头像
        ///</summary>
        public string Portrait { get; set; } // Portrait (length: 128)

        ///<summary>
        /// 商户GW号
        ///</summary>
        public string UserCode { get; set; } // UserCode (length: 50)

        ///<summary>
        /// 推荐人GW号
        ///</summary>
        public string ReferralCode { get; set; } // ReferralCode (length: 50)

        ///<summary>
        /// 身份证姓名
        ///</summary>
        public string RealName { get; set; } // RealName (length: 50)

        ///<summary>
        /// 身份证号
        ///</summary>
        public string IdCardNo { get; set; } // IDCardNO (length: 18)

        ///<summary>
        /// 身份证有效期
        ///</summary>
        public System.DateTime? IdCardValidTime { get; set; } // IDCardValidTime

        ///<summary>
        /// 身份证正面照
        ///</summary>
        public string IdCardFrontImg { get; set; } // IDCardFrontImg (length: 128)

        ///<summary>
        /// 身份证反面照
        ///</summary>
        public string IdCardBackImg { get; set; } // IDCardBackImg (length: 128)

        ///<summary>
        /// 销售渠道名称
        ///</summary>
        public string SalesOutletName { get; set; } // SalesOutletName (length: 128)

        ///<summary>
        /// 特需行业
        ///</summary>
        public string SpecialIndustry { get; set; } // SpecialIndustry

        ///<summary>
        /// 绑定银行账户身份证
        ///</summary>
        public string IdCardOfBindBank { get; set; } // IDCardOfBindBank (length: 18)

        ///<summary>
        /// 绑定银行账户身份证正面
        ///</summary>
        public string IdCardFrontImgOfBindBank { get; set; } // IDCardFrontImgOfBindBank (length: 128)

        ///<summary>
        /// 绑定银行账户身份证反面
        ///</summary>
        public string IdCardBackImgOfBindBank { get; set; } // IDCardBackImgOfBindBank (length: 128)

        ///<summary>
        /// 绑定银行账户身份证有效期
        ///</summary>
        public System.DateTime? IdCardExpDateOfBindBank { get; set; } // IDCardExpDateOfBindBank

        ///<summary>
        /// 省份
        ///</summary>
        public int? Province { get; set; } // Province

        ///<summary>
        /// 城市
        ///</summary>
        public int? City { get; set; } // City

        ///<summary>
        /// 区
        ///</summary>
        public int? District { get; set; } // District

        ///<summary>
        /// 店铺地址
        ///</summary>
        public string Address { get; set; } // Address (length: 128)

        ///<summary>
        /// 个体工商户执照/企业法人营业执照
        ///</summary>
        public string LicenseImg { get; set; } // LicenseImg (length: 128)

        ///<summary>
        /// 执照到期限期
        ///</summary>
        public System.DateTime? LicenseExpirationDate { get; set; } // LicenseExpirationDate

        ///<summary>
        /// 开户银行
        ///</summary>
        public string BindBank { get; set; } // BindBank (length: 128)

        ///<summary>
        /// 银行卡账户名
        ///</summary>
        public string BankAccountName { get; set; } // BankAccountName (length: 128)

        ///<summary>
        /// 银行卡号
        ///</summary>
        public string BankAccount { get; set; } // BankAccount (length: 50)

        ///<summary>
        /// 银行所属省份
        ///</summary>
        public int? BankProvince { get; set; } // BankProvince

        ///<summary>
        /// 银行所属市
        ///</summary>
        public int? BankCity { get; set; } // BankCity

        ///<summary>
        /// 银行所属区
        ///</summary>
        public int? BankDistrict { get; set; } // BankDistrict

        ///<summary>
        /// 开户支行
        ///</summary>
        public string BankBranch { get; set; } // BankBranch (length: 128)

        ///<summary>
        /// 银行卡/开户许可证图片
        ///</summary>
        public string BankCardImg { get; set; } // BankCardImg (length: 8000)

        ///<summary>
        /// 状态  0删除 1有效 2失效
        ///</summary>
        public int? Status { get; set; } // Status

        ///<summary>
        /// 备注
        ///</summary>
        public string Remark { get; set; } // Remark (length: 256)

        ///<summary>
        /// 店铺类型 对应gw_sku_store_category
        ///</summary>
        public int? StoreType { get; set; } // StoreType

        ///<summary>
        /// 创建时间
        ///</summary>
        public System.DateTime? CreateTime { get; set; } // CreateTime

        ///<summary>
        /// 更新时间
        ///</summary>
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        ///<summary>
        /// 店铺Logo
        ///</summary>
        public string StoreLogo { get; set; } // StoreLogo (length: 200)

        ///<summary>
        /// 经营分类
        ///</summary>
        public int? BusinessCategoryId { get; set; } // BusinessCategoryID

        ///<summary>
        /// 营业时间
        ///</summary>
        public string BusinessHours { get; set; } // BusinessHours (length: 200)

        ///<summary>
        /// 联系人姓名
        ///</summary>
        public string ContactName { get; set; } // ContactName (length: 50)

        ///<summary>
        /// 联系人电话
        ///</summary>
        public string ContactMobile { get; set; } // ContactMobile (length: 50)

        ///<summary>
        /// 营业执照名称
        ///</summary>
        public string LicenseName { get; set; } // LicenseName (length: 50)

        ///<summary>
        /// 账户类型：0:对私 1:对公
        ///</summary>
        public int? BankAccountType { get; set; } // BankAccountType

        ///<summary>
        /// 行业许可证
        ///</summary>
        public string IndustryLicenses { get; set; } // IndustryLicenses

        ///<summary>
        /// 门店电话
        ///</summary>
        public string StoreMobile { get; set; } // StoreMobile (length: 50)

        ///<summary>
        /// 0.申请中  3.营运中心确认费率  4.渠道审核通过  5.渠道审核不通过
        ///</summary>
        public int? ApprovalStatus { get; set; } // ApprovalStatus

        ///<summary>
        /// 临时服务费率
        ///</summary>
        public string TemporaryServiceFee { get; set; } // TemporaryServiceFee (length: 50)

        ///<summary>
        /// 银行编码
        ///</summary>
        public string BankCode { get; set; } // BankCode (length: 50)

        ///<summary>
        /// 服务码
        ///</summary>
        public string ServiceCode { get; set; } // ServiceCode (length: 50)

        ///<summary>
        /// 图片
        ///</summary>
        public string Images { get; set; } // Images (length: 4000)

        ///<summary>
        /// 经度
        ///</summary>
        public decimal? Longitude { get; set; } // Longitude

        ///<summary>
        /// 纬度
        ///</summary>
        public decimal? Latitude { get; set; } // Latitude

        ///<summary>
        /// 最终审批时间
        ///</summary>
        public System.DateTime? ApprovalTime { get; set; } // ApprovalTime

        ///<summary>
        /// 审批备注
        ///</summary>
        public string ApprovalNote { get; set; } // ApprovalNote (length: 4000)

        public MerchantApplication()
        {
            Province = 0;
            City = 0;
            District = 0;
            BankAccount = "0";
            BankProvince = 0;
            BankCity = 0;
            BankDistrict = 0;
            Status = 1;
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
            Longitude = 0m;
            Latitude = 0m;
        }
    }

}
// </auto-generated>