using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Enitites
{
    public partial class User
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
