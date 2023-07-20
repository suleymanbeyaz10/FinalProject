using System;
using System.Reflection.Metadata.Ecma335;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
