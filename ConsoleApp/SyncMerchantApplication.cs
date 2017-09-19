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

    // SyncMerchantApplication
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncMerchantApplication
    {
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)
        public long Id { get; set; } // ID (Primary key)
        public string Code { get; set; } // Code (length: 50)
        public string Name { get; set; } // Name (length: 20)
        public string Portrait { get; set; } // Portrait (length: 128)
        public string UserCode { get; set; } // UserCode (length: 50)
        public string ReferralCode { get; set; } // ReferralCode (length: 50)
        public string RealName { get; set; } // RealName (length: 24)
        public string IdCardNo { get; set; } // IDCardNO (length: 18)
        public System.DateTime? IdCardValidTime { get; set; } // IDCardValidTime
        public string IdCardFrontImg { get; set; } // IDCardFrontImg (length: 128)
        public string IdCardBackImg { get; set; } // IDCardBackImg (length: 128)
        public string SalesOutletName { get; set; } // SalesOutletName (length: 128)
        public string SpecialIndustry { get; set; } // SpecialIndustry
        public string IdCardOfBindBank { get; set; } // IDCardOfBindBank (length: 18)
        public string IdCardFrontImgOfBindBank { get; set; } // IDCardFrontImgOfBindBank (length: 128)
        public string IdCardBackImgOfBindBank { get; set; } // IDCardBackImgOfBindBank (length: 128)
        public System.DateTime? IdCardExpDateOfBindBank { get; set; } // IDCardExpDateOfBindBank
        public int? Province { get; set; } // Province
        public int? City { get; set; } // City
        public int? District { get; set; } // District
        public string Address { get; set; } // Address (length: 128)
        public string LicenseImg { get; set; } // LicenseImg (length: 128)
        public System.DateTime? LicenseExpirationDate { get; set; } // LicenseExpirationDate
        public string BindBank { get; set; } // BindBank (length: 128)
        public string BankAccountName { get; set; } // BankAccountName (length: 128)
        public string BankAccount { get; set; } // BankAccount (length: 50)
        public int? BankProvince { get; set; } // BankProvince
        public int? BankCity { get; set; } // BankCity
        public int? BankDistrict { get; set; } // BankDistrict
        public string BankBranch { get; set; } // BankBranch (length: 128)
        public string BankCardImg { get; set; } // BankCardImg (length: 128)
        public int? Status { get; set; } // Status
        public string Remark { get; set; } // Remark (length: 256)
        public int? StoreType { get; set; } // StoreType
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime
        public string StoreLogo { get; set; } // StoreLogo (length: 200)
        public int? BusinessCategoryId { get; set; } // BusinessCategoryID
        public string BusinessHours { get; set; } // BusinessHours (length: 200)
        public string ContactName { get; set; } // ContactName (length: 50)
        public string ContactMobile { get; set; } // ContactMobile (length: 50)
        public string LicenseName { get; set; } // LicenseName (length: 50)
        public int? BankAccountType { get; set; } // BankAccountType
        public string IndustryLicenses { get; set; } // IndustryLicenses
        public string StoreMobile { get; set; } // StoreMobile (length: 50)
        public int? ApprovalStatus { get; set; } // ApprovalStatus

        public SyncMerchantApplication()
        {
            UniqueId = System.Guid.NewGuid();
            Province = 0;
            City = 0;
            District = 0;
            BankAccount = "0";
            BankProvince = 0;
            BankCity = 0;
            BankDistrict = 0;
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>
