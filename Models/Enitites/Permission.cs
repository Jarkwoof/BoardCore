using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Enitites
{
    public partial class Permission
    {
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Guid ParentId { get; set; }
        public int Type { get; set; }
        public int Sort { get; set; }
        public string CreUid { get; set; }
        public DateTime CreDate { get; set; }
        public string ModUid { get; set; }
        public DateTime? ModDate { get; set; }
        public string Icon { get; set; }
        public bool? NeedPermission { get; set; }
        public bool? Status { get; set; }
    }
}
