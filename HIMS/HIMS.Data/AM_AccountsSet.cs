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
    
    public partial class AM_AccountsSet
    {
        public AM_AccountsSet()
        {
            this.OM_OrdersSet = new HashSet<OM_OrdersSet>();
        }
    
        public long AccountId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime JoinTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public string RoleId { get; set; }
        public long AM_Role_RoleId { get; set; }
    
        public virtual ICollection<OM_OrdersSet> OM_OrdersSet { get; set; }
        public virtual AM_RoleSet AM_RoleSet { get; set; }
    }
}
