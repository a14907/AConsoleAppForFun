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

    // SyncDevicePushLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SyncDevicePushLog
    {
        public System.Guid UniqueId { get; set; } // UniqueID (Primary key)
        public long Id { get; set; } // ID (Primary key)
        public string Code { get; set; } // Code (length: 50)
        public string SalesOrderCode { get; set; } // SalesOrderCode (length: 50)
        public string SendData { get; set; } // SendData
        public string ReceiveData { get; set; } // ReceiveData
        public System.DateTime? CreateTime { get; set; } // CreateTime
        public System.DateTime? UpdateTime { get; set; } // UpdateTime

        public SyncDevicePushLog()
        {
            UniqueId = System.Guid.NewGuid();
            CreateTime = System.DateTime.Now;
            UpdateTime = System.DateTime.Now;
        }
    }

}
// </auto-generated>