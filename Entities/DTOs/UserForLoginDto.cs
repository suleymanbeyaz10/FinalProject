using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
