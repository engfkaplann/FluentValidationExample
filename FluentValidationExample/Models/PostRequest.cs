using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationExample.Models
{
    public class PostRequest
    {
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
}
