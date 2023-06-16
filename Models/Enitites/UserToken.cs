using System;
using System.Collections.Generic;

#nullable disable

namespace BoardCore
{
    public partial class UserToken
    {
        public string Guid { get; set; }
        public string Account { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
