//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HIMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class RM_RoomsSet
    {
        public RM_RoomsSet()
        {
            this.RS_Order_RoomsSet = new HashSet<RS_Order_RoomsSet>();
        }
    
        public long RoomId { get; set; }
        public string Num { get; set; }
        public string Type { get; set; }
        public string Remark { get; set; }
        public string UpdateTime { get; set; }
        public string Operator { get; set; }
        public long RM_State_SID { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual ICollection<RS_Order_RoomsSet> RS_Order_RoomsSet { get; set; }
        public virtual RM_StateSet RM_StateSet { get; set; }
    }
}