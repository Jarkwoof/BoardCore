using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Enitites
{
    public class BaseEntity
    {
        public string Account { get; set; }
    }

    public partial class User : BaseEntity
    {
        public string Guid { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool Status { get; set; }
        public string CreUid { get; set; }
        public DateTime CreDate { get; set; }
        public string ModUid { get; set; }
        public DateTime? ModDate { get; set; }
    }
}
