//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MIS_Article
    {
        public string Id { get; set; }
        public int ChannelId { get; set; }
        public string CategoryId { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string BodyContent { get; set; }
        public Nullable<int> Sort { get; set; }
        public Nullable<int> Click { get; set; }
        public bool CheckFlag { get; set; }
        public string Checker { get; set; }
        public Nullable<System.DateTime> CheckDateTime { get; set; }
        public string Creater { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
    
        public virtual MIS_Article_Category MIS_Article_Category { get; set; }
        public virtual SysUser SysUser { get; set; }
        public virtual SysUser SysUser1 { get; set; }
    }
}
