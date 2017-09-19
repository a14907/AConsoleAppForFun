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

    // SyncSuperMarket
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncSuperMarket
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
        /// 门店名称
        ///</summary>
        public string Name { get; set; } // Name (length: 128)

        ///<summary>
        /// 商家ID
        ///</summary>
        public string MerchantUniqueId { get; set; } // MerchantUniqueID (length: 50)

        ///<summary>
        /// 销售网点分类
        ///</summary>
        public string BusinessCategoryId { get; set; } // BusinessCategoryID (length: 50)

        ///<summary>
        /// 手机号
        ///</summary>
        public string Mobile { get; set; } // Mobile (length: 32)

        ///<summary>
        /// 店铺标志
        ///</summary>
        public string Logo { get; set; } // Logo (length: 128)

        ///<summary>
        /// 省
        ///</summary>
        public int? Province { get; set; } // Province

        ///<summary>
        /// 市
        ///</summary>
        public int? City { get; set; } // City

        ///<summary>
        /// 区
        ///</summary>
        public int? District { get; set; } // District

        ///<summary>
        /// 街道
        ///</summary>
        public string Address { get; set; } // Address (length: 128)

        ///<summary>
        /// 邮政编码
        ///</summary>
        public string PostCode { get; set; } // PostCode (length: 16)

        ///<summary>
        /// 是否支持送货上门
        ///</summary>
        public bool? IsSupportDelivery { get; set; } // IsSupportDelivery

        ///<summary>
        /// 送货时间（支持送货的时间范围）
        ///</summary>
        public string DeliveryTimeRange { get; set; } // DeliveryTimeRange (length: 25)

        ///<summary>
        /// 起送金额
        ///</summary>
        public decimal? MinAmountOfDelivery { get; set; } // MinAmountOfDelivery

        ///<summary>
        /// 免费送货上门最低金额
        ///</summary>
        public decimal? MinAmountOfFreeDelivery { get; set; } // MinAmountOfFreeDelivery

        ///<summary>
        /// 配送费
        ///</summary>
        public decimal? DeliveryFee { get; set; } // DeliveryFee

        ///<summary>
        /// 经度
        ///</summary>
        public double? Longitude { get; set; } // Longitude

        ///<summary>
        /// 纬度
        ///</summary>
        public double? Latitude { get; set; } // Latitude

        ///<summary>
        /// 营业时间：6:00-22:00
        ///</summary>
        public string BusinessHours { get; set; } // BusinessHours (length: 25)

        ///<summary>
        /// 状态：0：申请；1：启用；2禁用
        ///</summary>
        public int? Status { get; set; } // Status

        ///<summary>
        /// 是否推荐
        ///</summary>
        public bool? IsRecommend { get; set; } // IsRecommend

        ///<summary>
        /// 在APP上的推荐版块位置
        ///</summary>
        public string RecommendPosition { get; set; } // RecommendPosition (length: 64)

        ///<summary>
        /// 每人每日的消费限额
        ///</summary>
        public decimal? CosumeLimitOfPersonPerday { get; set; } // CosumeLimitOfPersonPerday

        ///<summary>
        /// 已售商品数量
        ///</summary>
        public int? SoldProductNumber { get; set; } // SoldProductNumber

        ///<summary>
        /// 推荐人ID
        ///</summary>
        public string ReferralsUniqueId { get; set; } // ReferralsUniqueID (length: 50)

        ///<summary>
        /// 是否支持快捷支付
        ///</summary>
        public bool? SupportQuickPay { get; set; } // SupportQuickPay

        ///<summary>
        /// 优惠类型：1：无优惠；2：按比率优惠；3：满多少减多少（有上限）；4：满多少减多少（无上限）
        ///</summary>
        public int? DiscountType { get; set; } // DiscountType

        ///<summary>
        /// 使用优惠的最小订单金额
        ///</summary>
        public decimal? MinSalesOrderAmountOfDiscount { get; set; } // MinSalesOrderAmountOfDiscount

        ///<summary>
        /// 优惠金额
        ///</summary>
        public decimal? DiscountAmount { get; set; } // DiscountAmount

        ///<summary>
        /// 最大优惠金额
        ///</summary>
        public decimal? MaxDiscountAmount { get; set; } // MaxDiscountAmount

        ///<summary>
        /// 优惠折扣
        ///</summary>
        public decimal? DiscountRatio { get; set; } // DiscountRatio

        ///<summary>
        /// 推送号码
        ///</summary>
        public string PushMobile { get; set; } // PushMobile (length: 64)

        ///<summary>
        /// 创建时间
        ///</summary>
        public System.DateTime? CreateTime { get; set; } // CreateTime

        ///<summary>
        /// 更新时间
        ///</summary>
        public System.DateTime? UpdateTime { get; set; } // UpdateTime
        public int? TempMerchantId { get; set; } // TempMerchantID
        public int? TempBusinessCategoryId { get; set; } // TempBusinessCategoryID
        public string TempReferralsUserCode { get; set; } // TempReferralsUserCode (length: 50)
        public string MerchantCode { get; set; } // MerchantCode (length: 50)
        public string StoreUniqueId { get; set; } // StoreUniqueID (length: 50)
        public string ProvinceName { get; set; } // ProvinceName (length: 50)
        public string CityName { get; set; } // CityName (length: 50)
        public string DistrictName { get; set; } // DistrictName (length: 50)

        public SyncSuperMarket()
        {
            UniqueId = System.Guid.NewGuid();
            Province = 0;
            City = 0;
            District = 0;
            IsSupportDelivery = false;
            MinAmountOfDelivery = 0m;
            MinAmountOfFreeDelivery = 0m;
            DeliveryFee = 0m;
            Longitude = 0;
            Latitude = 0;
            IsRecommend = false;
            CosumeLimitOfPersonPerday = 0m;
            SoldProductNumber = 0;
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>