using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Enitites
{
    public partial class UserRole
    {
        public string Guid { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public bool Status { get; set; }
        public string CreUid { get; set; }
        public DateTime CreDate { get; set; }
        public string ModUid { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
