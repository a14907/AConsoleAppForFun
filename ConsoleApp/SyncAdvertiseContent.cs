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

    // SyncAdvertiseContent
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncAdvertiseContent
    {
        public int Id { get; set; } // ID (Primary key)
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)
        public string Code { get; set; } // Code (length: 50)
        public string Title { get; set; } // Title (length: 128)
        public System.Guid? PositionUniqueId { get; set; } // PositionUniqueID
        public System.DateTime? StartTime { get; set; } // StartTime
        public System.DateTime? EndTime { get; set; } // EndTime
        public string Content { get; set; } // Content
        public int? Sort { get; set; } // Sort
        public int? Status { get; set; } // Status
        public int? Province { get; set; } // Province
        public int? City { get; set; } // City
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime
        public int? TempAdvertiseId { get; set; } // TempAdvertiseID
        public string CountryName { get; set; } // CountryName (length: 50)
        public string ProvinceName { get; set; } // ProvinceName (length: 50)
        public string CityName { get; set; } // CityName (length: 50)

        public SyncAdvertiseContent()
        {
            UniqueId = System.Guid.NewGuid();
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>
