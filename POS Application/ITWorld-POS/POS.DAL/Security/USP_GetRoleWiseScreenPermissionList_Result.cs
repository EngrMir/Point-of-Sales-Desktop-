//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS.DAL.Security
{
    using System;
    
    public partial class USP_GetRoleWiseScreenPermissionList_Result
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public long ScreenId { get; set; }
        public string AccessRight { get; set; }
        public string CanRead { get; set; }
        public string CanCreate { get; set; }
        public string CanUpdate { get; set; }
        public string CanDelete { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime SetOn { get; set; }
        public long SetBy { get; set; }
        public string RoleName { get; set; }
        public long ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ScreenCode { get; set; }
        public string ScreenTitle { get; set; }
    }
}
