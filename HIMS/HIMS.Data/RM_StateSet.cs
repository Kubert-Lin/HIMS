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
    
    public partial class RM_StateSet
    {
        public RM_StateSet()
        {
            this.RM_RoomsSet = new HashSet<RM_RoomsSet>();
        }
    
        public long SID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    
        public virtual ICollection<RM_RoomsSet> RM_RoomsSet { get; set; }
    }
}
